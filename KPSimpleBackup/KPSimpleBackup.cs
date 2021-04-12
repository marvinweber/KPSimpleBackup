using System;
using System.Diagnostics;
using System.Windows.Forms;
using KeePass.Forms;
using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Utility;
using KeePassLib.Interfaces;

namespace KPSimpleBackup
{
    public sealed class KPSimpleBackupExt : Plugin
    {
        private IPluginHost m_host = null;
        private KPSimpleBackupConfig m_config = null;
        private Logger m_PluginLogger = null;
        
        /// <summary>
        /// This flag keeps track of whether the database has been modified
        /// since the last backup, or not.
        /// </summary>
        private bool m_databaseModifiedAfterLastBackup = false;

        public override bool Initialize(IPluginHost host)
        {
            if (host == null) return false;

            m_host = host;
            m_config = new KPSimpleBackupConfig(m_host.CustomConfig);
            m_PluginLogger = new Logger(m_config.LogToFile);

            BackupManager.SetConfig(m_config);
            BackupManager.SetPluginLogger(m_PluginLogger);
            CleanupManager.config = m_config;

            // add handler for KeePass events this plugin reacts to (file saving, closing, etc.)
            m_host.MainWindow.FileSaving += this.OnDatabaseSavingPreAction;
            m_host.MainWindow.FileSaved += this.OnDatabaseSaveAction;
            m_host.MainWindow.FileClosingPost += this.OnDatabaseCloseAction;

            // initialization successful
            return true;
        }

        public override void Terminate()
        {
            // Remove event handlers
            m_host.MainWindow.FileSaving -= this.OnDatabaseSavingPreAction;
            m_host.MainWindow.FileSaved -= this.OnDatabaseSaveAction;
            m_host.MainWindow.FileClosingPost -= this.OnDatabaseCloseAction;

            m_PluginLogger.Terminate();
        }

        public override string UpdateUrl
        {
            get
            {
                return "https://raw.githubusercontent.com/marvinweber/KPSimpleBackup/master/kpsimplebackup.version";
            }
        }

        public override ToolStripMenuItem GetMenuItem(PluginMenuType t)
        {
            // Provide a menu item for the main location(s)
            if (t == PluginMenuType.Main)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();

                tsmi.Text = "KPSimpleBackup";

                ToolStripMenuItem backupNowItem = new ToolStripMenuItem();
                backupNowItem.Text = "Backup Database now!";
                backupNowItem.Click += this.OnMenuBackupNow;

                ToolStripMenuItem openSettings = new ToolStripMenuItem();
                openSettings.Text = "Settings";
                openSettings.Click += this.OnMenuSettings;

                ToolStripMenuItem openLog = new ToolStripMenuItem();
                openLog.Text = "Open Session Log";
                openLog.Click += this.OnMenuShowLog;


                tsmi.DropDownItems.Add(backupNowItem);
                tsmi.DropDownItems.Add(openSettings);
                tsmi.DropDownItems.Add(openLog);

                return tsmi;
            }

            return null; // No menu items in other locations
        }

        private void OnMenuSettings(object sender, EventArgs e)
        {
            SettingsForm settingsWindow = new SettingsForm(this.m_config);
            settingsWindow.ShowDialog();
            settingsWindow.Dispose();
            settingsWindow = null;
        } 

        private void OnMenuShowLog(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm(this.m_PluginLogger);
            logForm.ShowDialog();
            logForm.Dispose();
        }

        /// <summary>
        /// Handler to be called before the KeePass Database is saved. It checks
        /// whether the database has been modified and updates the internal flag
        /// of this class accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDatabaseSavingPreAction(object sender, FileSavingEventArgs e)
        {
            m_databaseModifiedAfterLastBackup = m_databaseModifiedAfterLastBackup || e.Database.Modified;
        }

        private void OnDatabaseSaveAction(object sender, FileSavedEventArgs e)
        {
            // only create backup if auto-backup is enabled
            if (this.m_config.AutoDatabaseBackup)
            {
                this.BackupAction(e.Database);
            }
        }

        /// <summary>
        /// Handler to be called whenever the database is closed (i.e., it is called
        /// when the database is locked, closed or KeePass is closed).
        /// If enabled by the user ("backup-on-close") and the database is opened and
        /// modified (or was modified and saved after the last backup), a backup will
        /// be triggered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">File closing event containing the database object</param>
        private void OnDatabaseCloseAction(object sender, FileClosingEventArgs e)
        {
            // perform backup if "backup-on-close" is configured and database is opened
            // and modified (or was modified and saved since the last backup) as well
            // (prevent backups of unmodified database)
            if (
                this.m_config.BackupOnDbClose &&
                e.Database.IsOpen &&
                (e.Database.Modified || m_databaseModifiedAfterLastBackup)
            ) {
                this.BackupAction(e.Database);
            }
        }

        private void OnMenuBackupNow(object sender, EventArgs e)
        {
            // show warning and return if configuration isn't finished
            if (!this.m_config.BackupConfigured)
            {
                MessageService.ShowWarning(
                    "Database backup cannot be created, because the configuration is not finished.",
                    "Please goto \"Tools -> KPSimpleBackup -> Settings\" and add a backup folder!"
                );
                return;
            }
            this.BackupAction(m_host.Database);
        }

        private void BackupAction(PwDatabase database)
        {
            // don't perform backup if configuration isn't finished
            if (!this.m_config.BackupConfigured)
            {
                return;
            }

            // start stopwatch to measure time needed for the backup
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            IStatusLogger swLogger = this.m_host.MainWindow.CreateShowWarningsLogger();
            try
            {
                m_host.MainWindow.UIBlockInteraction(true);
                bool warnings = false;

                BackupManager.SetKPMainWindowSwLogger(swLogger);
                swLogger.SetText("KPSimpleBackup: Backup started...", LogStatusType.Info);
                m_PluginLogger.Log("KPSimpleBackup: Backup started...", LogStatusType.Info);

                BasicBackupManager basicBackupManager = new BasicBackupManager(database);
                warnings = ! basicBackupManager.Run() || warnings;

                // perform long term backup if enabled in settings
                if (m_config.UseLongTermBackup)
                {
                    LongTermBackupManager ltbManager = new LongTermBackupManager(database);
                    if (basicBackupManager.lastBackupFilePath != null)
                    {
                        ltbManager.SetTempDatabaseBackupFile(basicBackupManager.lastBackupFilePath);
                    }
                    warnings = ! ltbManager.Run() || warnings;
                }

                // reset database modified property, as an up-to-date backup has now been created
                m_databaseModifiedAfterLastBackup = false;

                // backup KeePass configuration if enabled in settings
                if (m_config.BackupKeePassConfig)
                {
                    KPConfigBackupManager kPConfigBackupManager = new KPConfigBackupManager(database);
                    warnings = ! kPConfigBackupManager.Run() || warnings;
                }

                if (warnings)
                {
                    swLogger.SetText("KPSimpleBackup: Backup finished with warnings, consider checking the logs!", LogStatusType.Info);
                    if (m_config.ShowBackupFailedWarning)
                    {
                        MessageService.ShowWarning(
                            "KPSimpleBackup: Backup finished with warnings, check the logs for details!"
                        );
                    }
                }
                else
                {
                    swLogger.SetText("KPSimpleBackup: Backup finished!", LogStatusType.Info);
                }
            }
            catch (Exception e)
            {
                swLogger.EndLogging();
                swLogger.SetText("KPSimpleBackup: Backup failed, see logs for details!", LogStatusType.Error);

                m_PluginLogger.Log("Could not backup database! Error:", LogStatusType.Error);
                m_PluginLogger.Log(e.ToString(), LogStatusType.Error);
            }
            finally
            {
                m_host.MainWindow.UIBlockInteraction(false);
                stopWatch.Stop();
                m_PluginLogger.Log("KPSimpleBackup: Finished in " + stopWatch.ElapsedMilliseconds + " ms.", LogStatusType.Info);
            }
        }
    }
}