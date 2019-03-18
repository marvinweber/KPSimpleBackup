using System;
using System.Windows.Forms;
using KeePass.Forms;
using KeePass.Plugins;
using KeePassLib;
using KeePassLib.Serialization;

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
                return "https://www.weberone.de/kpsimplebackup.version";
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

        private void BackupAction(PwDatabase database)
        {
            string dbName = database.Name;
            string time = DateTime.Now.ToString(@"yyyy\.MM\.dd\_H\.mm\.ss");
            string backupFolderPath = this.m_config.BackupPath;
            string path = backupFolderPath + dbName + "_" + time + ".kdbx";
            IOConnectionInfo connection = IOConnectionInfo.FromPath(path);

            // save database TODO add Logger
            database.SaveAs(connection, false, null);
        }

        private void OnMenuBackupNow(object sender, EventArgs e)
        {
            this.BackupAction(m_host.Database);
        }


    }
}