using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KPSimpleBackup
{
    public partial class SettingsForm : Form
    {
        private KPSimpleBackupConfig appConfig;
        private static readonly String DATE_FORMAT_REGEX = "[^A-Za-z0-9:._+-;]";

        public SettingsForm(KPSimpleBackupConfig config)
        {
            this.appConfig = config;

            InitializeComponent();

            // load (already) configured values
            this.LoadValues();
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Select a backup folder";
            dialog.UseDescriptionForTitle = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string pathSelected = dialog.SelectedPath;

                // replace backslash (windows-specific) with slash
                pathSelected = pathSelected.Replace("\\", "/");

                string newPath = pathSelected + "/";

                // add new path to the list box
                listBoxBackupPaths.Items.Add(newPath);
            }
        }

        private void buttonRemoveSelectedFolder_Click(object sender, EventArgs e)
        {
            // return if no item is selected
            if (listBoxBackupPaths.SelectedIndex == -1)
            {
                return;
            }

            // remove item from listBox
            listBoxBackupPaths.Items.RemoveAt(listBoxBackupPaths.SelectedIndex);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // save values and close settings form
            this.appConfig.FileAmountToKeep = (long) numericNumberOfBackups.Value;
            this.appConfig.UseDatabaseNameForBackupFiles = checkBoxUseDbName.Checked;
            this.appConfig.UseRecycleBinDeletedBackups = checkBoxUseRecycleBin.Checked;
            this.appConfig.AutoDatabaseBackup = checkBoxAutoBackup.Checked;

            // custom file extension
            this.appConfig.UseCustomBackupFileExtension = checkBoxCustomFileEnding.Checked;
            string backupFileExtension = textBoxBackupFileEnding.Text;
            // add prepending point at beginning of file-extension if not set by user
            if (backupFileExtension.ToCharArray()[0] != '.')
            {
                backupFileExtension = "." + backupFileExtension;
            }
            this.appConfig.BackupFileExtension = backupFileExtension;

            // date format
            this.appConfig.DateFormat = textBoxDateFormat.Text;

            // save paths
            List<String> paths = new List<String>();
            foreach (object item in listBoxBackupPaths.Items)
            {
                paths.Add((string)item);
            }
            this.appConfig.BackupPath = paths;

            this.Close();
        }

        private void LoadValues()
        {
            checkBoxUseDbName.Checked = this.appConfig.UseDatabaseNameForBackupFiles;
            numericNumberOfBackups.Value = this.appConfig.FileAmountToKeep;
            checkBoxUseRecycleBin.Checked = this.appConfig.UseRecycleBinDeletedBackups;
            checkBoxAutoBackup.Checked = this.appConfig.AutoDatabaseBackup;

            // custom file extension checkbox & text box
            checkBoxCustomFileEnding.Checked = this.appConfig.UseCustomBackupFileExtension;
            textBoxBackupFileEnding.Text = this.appConfig.BackupFileExtension;
            textBoxBackupFileEnding.Enabled = this.appConfig.UseCustomBackupFileExtension;

            // date format
            textBoxDateFormat.Text = this.appConfig.DateFormat;

            // version label
            labelVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.LoadBackupPaths();
        }

        private void LoadBackupPaths()
        {
            // remove all items to prevent duplicate entries in the box
            listBoxBackupPaths.Items.Clear();

            List<String> paths = this.appConfig.BackupPath;

            foreach(String path in paths)
            {
                // skip empty paths
                if (path != "")
                {
                    listBoxBackupPaths.Items.Add(path);
                }
            }
        }

        private void listBoxBackupPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable / disable remove button depending on whether a item is selected or not
            buttonRemoveSelectedFolder.Enabled = listBoxBackupPaths.SelectedIndex != -1;
        }

        private void buttonDateFormatHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings");
        }

        private void textBoxDateFormat_TextChanged(object sender, EventArgs e)
        {
            // validate date format input (remove invalid characters)
            textBoxDateFormat.Text = Regex.Replace(textBoxDateFormat.Text, DATE_FORMAT_REGEX, "");
        }

        private void linkLabelReportBug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/weberonede/KPSimpleBackup/issues");
        }

        private void LinkLabelRessourcesOokiDialogsWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ookii.org/Software/Dialogs/");
        }

        private void LinkLabelRessourcesOokiDialogsGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/caioproiete/ookii-dialogs-winforms");
        }

        private void CheckBoxCustomFileEnding_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkbox = sender as System.Windows.Forms.CheckBox;
            if (checkbox != null)
            {
                textBoxBackupFileEnding.Enabled = checkbox.Checked;
            }
        }
    }
}
