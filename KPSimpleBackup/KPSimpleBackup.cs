﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using KeePass.Forms;
using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Serialization;
using KeePassLib.Utility;
using Microsoft.VisualBasic.FileIO;
using KeePassLib.Interfaces;
using KeePass.Resources;

namespace KPSimpleBackup
{
    public sealed class KPSimpleBackupExt : Plugin
    {
        private const string FILE_PREFIX = "file:///";

        private IPluginHost m_host = null;
        private KPSimpleBackupConfig m_config = null;
        private Logger m_logger = null;

        public override bool Initialize(IPluginHost host)
        {
            if (host == null) return false;

            m_host = host;
            m_config = new KPSimpleBackupConfig(m_host.CustomConfig);
            m_logger = new Logger(m_config);

            BackupManager.SetConfig(m_config);
            BackupManager.SetPluginLogger(m_logger);

            // add backup action event handlers for when db is being saved and closed
            m_host.MainWindow.FileSaved += this.OnDatabaseSaveAction;
            m_host.MainWindow.FileClosingPre += this.OnDatabaseCloseAction;

            // initialization successful
            return true;
        }

        public override void Terminate()
        {
            // Remove event handler
            m_host.MainWindow.FileSaved -= this.OnDatabaseSaveAction;
            m_host.MainWindow.FileClosingPost -= this.OnDatabaseCloseAction;
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
            LogForm logForm = new LogForm(this.m_logger);
            logForm.ShowDialog();
            logForm.Dispose();
        }

        private void OnDatabaseSaveAction(object sender, FileSavedEventArgs e)
        {
            // only create backup if auto-backup is enabled
            if (this.m_config.AutoDatabaseBackup)
            {
                this.BackupAction(e.Database);
            }
        }

        private void OnDatabaseCloseAction(object sender, FileClosingEventArgs e)
        {
            if (this.m_config.BackupOnDbClose && e.Database.IsOpen)
            {
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

            // Get extension/ fileending for the database backup-file
            string databaseExtension = KPSimpleBackupConfig.DEFAULT_BACKUP_FILE_EXTENSION;
            if (this.m_config.UseCustomBackupFileExtension)
            {
                databaseExtension = this.m_config.BackupFileExtension;
            }
            else
            {
                string databasePath = database.IOConnectionInfo.Path;
                databaseExtension = Path.GetExtension(databasePath);
            }

            List<String> paths = this.m_config.BackupPath;
            String dateTimeFormat = this.m_config.DateFormat;
            string time = DateTime.Now.ToString(dateTimeFormat);

            this.m_host.MainWindow.UIBlockInteraction(true);

            IStatusLogger swLogger = this.m_host.MainWindow.CreateShowWarningsLogger();
            BackupManager.SetKPMainWindowSwLogger(swLogger);

            // Save backup database for each specified path and perform cleanup
            foreach (String backupFolderPath in paths)
            {
                try
                {
                    string dbBackupFileName = this.GetBackupFileName(database);
                    string path = FILE_PREFIX + backupFolderPath + dbBackupFileName + "_" + time + databaseExtension;

                    this.m_logger.Log("Start basic backup of database '" + database.Name + "' to path: " + path, LogStatusType.Info);

                    IOConnectionInfo connection = IOConnectionInfo.FromPath(path);

                    swLogger.StartLogging(KPRes.SavingDatabase, true);
                    database.SaveAs(connection, false, swLogger);
                    swLogger.EndLogging();

                    // Cleanup
                    string cleanupSearchPattern = dbBackupFileName + "_*" + databaseExtension;
                    this.Cleanup(backupFolderPath, cleanupSearchPattern, database.IOConnectionInfo.Path);

                    this.m_logger.Log("Finished basic backup of database '" + database.Name + "' to path: " + path, LogStatusType.Info);
                }
                catch (Exception e)
                {
                    this.m_logger.Log("Could not backup database! Error:", LogStatusType.Error);
                    this.m_logger.Log(e.ToString(), LogStatusType.Error);
                }
            }

            // perform long term backup if enabled in settings
            if (this.m_config.UseLongTermBackup)
            {
                LongTermBackupManager ltbManager = new LongTermBackupManager(database);
                ltbManager.Run();
            }

            this.m_host.MainWindow.UIBlockInteraction(false);
        }

        private String GetBackupFileName(PwDatabase database)
        {
            // start with database name as 'fallback' / default
            string backupFileName = database.Name;

            // get file name if database name shouldn't be used
            if (!this.m_config.UseDatabaseNameForBackupFiles)
            {
                string path = database.IOConnectionInfo.Path;
                backupFileName = Path.GetFileNameWithoutExtension(path);
            }

            return backupFileName;
        }

        private void Cleanup(String path, String searchPattern, String originalDatabasePath)
        {
            int filesToKeepAmount = (int) this.m_config.FileAmountToKeep;
            // read from settings whether to use recycle bin or delete files permanently
            var recycleOption = this.m_config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;

            String[] fileList = Directory.GetFiles(path, searchPattern).OrderBy(f => f).Reverse().ToArray();

            // if more backup files available than needed loop through the unnecessary ones and remove them
            if (fileList.Count() > filesToKeepAmount)
            {
                for (int i = filesToKeepAmount; i < fileList.Count(); i++)
                {
                    // never delete original file -> always skip it (in case it made it in the filelist)
                    if (fileList[i].Equals(originalDatabasePath))
                    {
                        continue;
                    }

                    FileSystem.DeleteFile(fileList[i], UIOption.OnlyErrorDialogs, recycleOption);
                }
            }
        }
    }
}