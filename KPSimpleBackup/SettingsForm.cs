using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            labelSelectedBackupPath.Text = this.appConfig.BackupPath;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Backup Path";
            objDialog.SelectedPath = @"C:\";
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                string pathSelected = objDialog.SelectedPath;
                pathSelected = pathSelected.Replace("\\", "/");

                string newPath = "file:///" + pathSelected + "/";

                this.appConfig.BackupPath = newPath;
                this.appConfig.BackupConfigured = true;
                this.labelSelectedBackupPath.Text = newPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
