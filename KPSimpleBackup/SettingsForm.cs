using System;
using System.Windows.Forms;

namespace KPSimpleBackup
{
    public partial class SettingsForm : Form
    {
        private KPSimpleBackupConfig appConfig;

        public SettingsForm(KPSimpleBackupConfig config)
        {
            this.appConfig = config;

            InitializeComponent();

            // load (already) configured values
            this.LoadValues();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Backup Path";
            objDialog.SelectedPath = @"C:\";
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                string pathSelected = objDialog.SelectedPath;

                // replace backslash (windows-specific) with slash
                pathSelected = pathSelected.Replace("\\", "/");

                string newPath = pathSelected + "/";

                this.appConfig.BackupPath = newPath;
                labelSelectedBackupPath.Text = this.appConfig.BackupPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // save values and close settings form
            this.appConfig.FileAmountToKeep = (long) numericNumberOfBackups.Value;
            this.appConfig.UseDatabaseNameForBackupFiles = checkBoxUseDbName.Checked;

            this.Close();
        }

        private void LoadValues()
        {
            labelSelectedBackupPath.Text = this.appConfig.BackupPath;
            checkBoxUseDbName.Checked = this.appConfig.UseDatabaseNameForBackupFiles;
            numericNumberOfBackups.Value = this.appConfig.FileAmountToKeep;
        }
    }
}
