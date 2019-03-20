using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using KeePass.Forms;
using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Serialization;
using KeePassLib.Utility;
using Microsoft.VisualBasic.FileIO;

namespace KPSimpleBackup
{
    public sealed class KPSimpleBackupExt : Plugin
    {
        private IPluginHost m_host = null;
        private KPSimpleBackupConfig m_config = null;

        public override bool Initialize(IPluginHost host)
        {
            if (host == null) return false;

            m_host = host;
            m_config = new KPSimpleBackupConfig(m_host.CustomConfig);

            // add backup action event handler
            m_host.MainWindow.FileSaved += this.OnSaveAction;

            // initialization successful
            return true;
        }

        public override void Terminate()
        {
            // Remove event handler
            m_host.MainWindow.FileSaved -= this.OnSaveAction;
        }

        public override string UpdateUrl
        {
            get
            {
                return "https://raw.githubusercontent.com/weberonede/KPSimpleBackup/master/kpsimplebackup.version";
            }
        }

        public override ToolStripMenuItem GetMenuItem(PluginMenuType t)
        {
            // Provide a menu item for the main location(s)
            if (t == PluginMenuType.Main)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();

                tsmi.Text = "KPSimpleBackup";
                //tsmi.Click += this.OnOptionsClicked;

                ToolStripMenuItem backupNowItem = new ToolStripMenuItem();
                backupNowItem.Text = "Backup Database now!";
                backupNowItem.Click += this.OnMenuBackupNow;

                ToolStripMenuItem openSettings = new ToolStripMenuItem();
                openSettings.Text = "Settings";
                openSettings.Click += this.OnMenuSettings;


                tsmi.DropDownItems.Add(backupNowItem);
                tsmi.DropDownItems.Add(openSettings);

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

        private void OnSaveAction(object sender, FileSavedEventArgs e)
        {
            this.BackupAction(e.Database);
        }

        private void OnMenuBackupNow(object sender, EventArgs e)
        {
            // show warning and abort if configuration isn't finished
            if (!this.m_config.BackupConfigured)
            {
                MessageService.ShowWarning(
                    "Database cannot be backuped, because configuration is not finished.",
                    "Goto Tools -> KPSimpleBackup -> Settings and finish configuration!"
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

            string dbBackupFileName = this.GetBackupFileName(database);
            string time = DateTime.Now.ToString(@"yyyy\.MM\.dd\_H\.mm\.ss");
            string backupFolderPath = this.m_config.BackupPath;
            string path = "file:///" + backupFolderPath + dbBackupFileName + "_" + time + ".kdbx";
            IOConnectionInfo connection = IOConnectionInfo.FromPath(path);

            // save database TODO add Logger
            database.SaveAs(connection, false, null);

            // Cleanup
            this.Cleanup(backupFolderPath, dbBackupFileName);
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

        private void Cleanup(String path, String fileNamePrefix)
        {
            int filesToKeepAmount = (int)this.m_config.FileAmountToKeep;
            // read from settings wether to use recycle bin or delete files permanently
            var recycleOption = this.m_config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;

            String searchPattern = fileNamePrefix + "*" + ".kdbx";
            String[] fileList = Directory.GetFiles(path, searchPattern).OrderBy(f => f).Reverse().ToArray();

            // if more backup files available than needed loop through the unnecessary ones and remove them
            if (fileList.Count() > filesToKeepAmount)
            {
                for (int i = filesToKeepAmount; i < fileList.Count(); i++)
                {
                    FileSystem.DeleteFile(fileList[i], UIOption.OnlyErrorDialogs, recycleOption);
                }
            }
        }
    }
}