namespace KPSimpleBackup
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.LinkLabel linkLabelRessourcesOokiDialogsWebsite;
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericNumberOfBackups = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRemoveSelectedFolder = new System.Windows.Forms.Button();
            this.listBoxBackupPaths = new System.Windows.Forms.ListBox();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDateFormatHelp = new System.Windows.Forms.Button();
            this.textBoxDateFormat = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxUseDbName = new System.Windows.Forms.CheckBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxAutoBackup = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUseRecycleBin = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabelReportBug = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabelRessourcesOokiDialogsGitHub = new System.Windows.Forms.LinkLabel();
            this.checkBoxCustomFileEnding = new System.Windows.Forms.CheckBox();
            this.textBoxBackupFileEnding = new System.Windows.Forms.TextBox();
            this.checkBoxBackupOnDbClose = new System.Windows.Forms.CheckBox();
            linkLabelRessourcesOokiDialogsWebsite = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfBackups)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 317);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.31961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.68039F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericNumberOfBackups, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 311);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of backups to keep:";
            // 
            // numericNumberOfBackups
            // 
            this.numericNumberOfBackups.Location = new System.Drawing.Point(188, 4);
            this.numericNumberOfBackups.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNumberOfBackups.Name = "numericNumberOfBackups";
            this.numericNumberOfBackups.Size = new System.Drawing.Size(317, 20);
            this.numericNumberOfBackups.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder for backup files:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRemoveSelectedFolder);
            this.panel2.Controls.Add(this.listBoxBackupPaths);
            this.panel2.Controls.Add(this.buttonAddFolder);
            this.panel2.Location = new System.Drawing.Point(188, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 238);
            this.panel2.TabIndex = 4;
            // 
            // buttonRemoveSelectedFolder
            // 
            this.buttonRemoveSelectedFolder.Enabled = false;
            this.buttonRemoveSelectedFolder.Location = new System.Drawing.Point(176, 2);
            this.buttonRemoveSelectedFolder.Name = "buttonRemoveSelectedFolder";
            this.buttonRemoveSelectedFolder.Size = new System.Drawing.Size(138, 23);
            this.buttonRemoveSelectedFolder.TabIndex = 5;
            this.buttonRemoveSelectedFolder.Text = "Remove selected folder";
            this.buttonRemoveSelectedFolder.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedFolder.Click += new System.EventHandler(this.buttonRemoveSelectedFolder_Click);
            // 
            // listBoxBackupPaths
            // 
            this.listBoxBackupPaths.FormattingEnabled = true;
            this.listBoxBackupPaths.HorizontalScrollbar = true;
            this.listBoxBackupPaths.Location = new System.Drawing.Point(3, 32);
            this.listBoxBackupPaths.Name = "listBoxBackupPaths";
            this.listBoxBackupPaths.ScrollAlwaysVisible = true;
            this.listBoxBackupPaths.Size = new System.Drawing.Size(311, 199);
            this.listBoxBackupPaths.TabIndex = 4;
            this.listBoxBackupPaths.SelectedIndexChanged += new System.EventHandler(this.listBoxBackupPaths_SelectedIndexChanged);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFolder.TabIndex = 2;
            this.buttonAddFolder.Text = "Add folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date format:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDateFormatHelp);
            this.panel3.Controls.Add(this.textBoxDateFormat);
            this.panel3.Location = new System.Drawing.Point(188, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 31);
            this.panel3.TabIndex = 7;
            // 
            // buttonDateFormatHelp
            // 
            this.buttonDateFormatHelp.Location = new System.Drawing.Point(294, 4);
            this.buttonDateFormatHelp.Name = "buttonDateFormatHelp";
            this.buttonDateFormatHelp.Size = new System.Drawing.Size(20, 20);
            this.buttonDateFormatHelp.TabIndex = 1;
            this.buttonDateFormatHelp.Text = "?";
            this.buttonDateFormatHelp.UseVisualStyleBackColor = true;
            this.buttonDateFormatHelp.Click += new System.EventHandler(this.buttonDateFormatHelp_Click);
            // 
            // textBoxDateFormat
            // 
            this.textBoxDateFormat.Location = new System.Drawing.Point(3, 4);
            this.textBoxDateFormat.Name = "textBoxDateFormat";
            this.textBoxDateFormat.Size = new System.Drawing.Size(285, 20);
            this.textBoxDateFormat.TabIndex = 0;
            this.textBoxDateFormat.TextChanged += new System.EventHandler(this.textBoxDateFormat_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(472, 373);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxUseDbName
            // 
            this.checkBoxUseDbName.AutoSize = true;
            this.checkBoxUseDbName.Location = new System.Drawing.Point(6, 28);
            this.checkBoxUseDbName.Name = "checkBoxUseDbName";
            this.checkBoxUseDbName.Size = new System.Drawing.Size(335, 30);
            this.checkBoxUseDbName.TabIndex = 7;
            this.checkBoxUseDbName.Text = "Use Database-Name (File -> Database-Settings -> Name) instead \r\nof File-Name (Def" +
    "ault) for Backup-File-Names";
            this.checkBoxUseDbName.UseVisualStyleBackColor = true;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Controls.Add(this.tabPage3);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(535, 355);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxBackupOnDbClose);
            this.tabPage2.Controls.Add(this.textBoxBackupFileEnding);
            this.tabPage2.Controls.Add(this.checkBoxCustomFileEnding);
            this.tabPage2.Controls.Add(this.checkBoxAutoBackup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.checkBoxUseRecycleBin);
            this.tabPage2.Controls.Add(this.checkBoxUseDbName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoBackup
            // 
            this.checkBoxAutoBackup.AutoSize = true;
            this.checkBoxAutoBackup.Location = new System.Drawing.Point(6, 87);
            this.checkBoxAutoBackup.Name = "checkBoxAutoBackup";
            this.checkBoxAutoBackup.Size = new System.Drawing.Size(247, 17);
            this.checkBoxAutoBackup.TabIndex = 10;
            this.checkBoxAutoBackup.Text = "Auto backup Database (every time you save it)";
            this.checkBoxAutoBackup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Only change these settings if you really know what you are doing ;)";
            // 
            // checkBoxUseRecycleBin
            // 
            this.checkBoxUseRecycleBin.AutoSize = true;
            this.checkBoxUseRecycleBin.Location = new System.Drawing.Point(6, 64);
            this.checkBoxUseRecycleBin.Name = "checkBoxUseRecycleBin";
            this.checkBoxUseRecycleBin.Size = new System.Drawing.Size(400, 17);
            this.checkBoxUseRecycleBin.TabIndex = 8;
            this.checkBoxUseRecycleBin.Text = "Use Recycle Bin (Deleted Backup-Files will stay in recycle bin until you emtpy it" +
    ")";
            this.checkBoxUseRecycleBin.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(linkLabelRessourcesOokiDialogsWebsite);
            this.tabPage3.Controls.Add(this.linkLabelRessourcesOokiDialogsGitHub);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.linkLabelReportBug);
            this.tabPage3.Controls.Add(this.labelVersion);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(527, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabelReportBug
            // 
            this.linkLabelReportBug.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelReportBug.AutoSize = true;
            this.linkLabelReportBug.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelReportBug.Location = new System.Drawing.Point(8, 64);
            this.linkLabelReportBug.Name = "linkLabelReportBug";
            this.linkLabelReportBug.Size = new System.Drawing.Size(61, 13);
            this.linkLabelReportBug.TabIndex = 2;
            this.linkLabelReportBug.TabStop = true;
            this.linkLabelReportBug.Text = "Report Bug";
            this.linkLabelReportBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReportBug_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(8, 39);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "KPSimpleBackup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(389, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Open source software used in KPSimpleBackup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(435, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ookii.Dialogs.WinForms - Copyright (c) Sven Groot (Ookii.org) 2009";
            // 
            // linkLabelRessourcesOokiDialogsGitHub
            // 
            this.linkLabelRessourcesOokiDialogsGitHub.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelRessourcesOokiDialogsGitHub.AutoSize = true;
            this.linkLabelRessourcesOokiDialogsGitHub.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelRessourcesOokiDialogsGitHub.Location = new System.Drawing.Point(8, 166);
            this.linkLabelRessourcesOokiDialogsGitHub.Name = "linkLabelRessourcesOokiDialogsGitHub";
            this.linkLabelRessourcesOokiDialogsGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkLabelRessourcesOokiDialogsGitHub.TabIndex = 5;
            this.linkLabelRessourcesOokiDialogsGitHub.TabStop = true;
            this.linkLabelRessourcesOokiDialogsGitHub.Text = "GitHub";
            this.linkLabelRessourcesOokiDialogsGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRessourcesOokiDialogsGitHub_LinkClicked);
            // 
            // linkLabelRessourcesOokiDialogsWebsite
            // 
            linkLabelRessourcesOokiDialogsWebsite.ActiveLinkColor = System.Drawing.Color.DarkRed;
            linkLabelRessourcesOokiDialogsWebsite.AutoSize = true;
            linkLabelRessourcesOokiDialogsWebsite.LinkColor = System.Drawing.Color.DarkRed;
            linkLabelRessourcesOokiDialogsWebsite.Location = new System.Drawing.Point(54, 166);
            linkLabelRessourcesOokiDialogsWebsite.Name = "linkLabelRessourcesOokiDialogsWebsite";
            linkLabelRessourcesOokiDialogsWebsite.Size = new System.Drawing.Size(46, 13);
            linkLabelRessourcesOokiDialogsWebsite.TabIndex = 6;
            linkLabelRessourcesOokiDialogsWebsite.TabStop = true;
            linkLabelRessourcesOokiDialogsWebsite.Text = "Website";
            linkLabelRessourcesOokiDialogsWebsite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LinkLabelRessourcesOokiDialogsWebsite_MouseClick);
            // 
            // checkBoxCustomFileEnding
            // 
            this.checkBoxCustomFileEnding.AutoSize = true;
            this.checkBoxCustomFileEnding.Location = new System.Drawing.Point(6, 133);
            this.checkBoxCustomFileEnding.Name = "checkBoxCustomFileEnding";
            this.checkBoxCustomFileEnding.Size = new System.Drawing.Size(240, 17);
            this.checkBoxCustomFileEnding.TabIndex = 11;
            this.checkBoxCustomFileEnding.Text = "Always use custom file-ending for backup-file:";
            this.checkBoxCustomFileEnding.UseVisualStyleBackColor = true;
            this.checkBoxCustomFileEnding.CheckedChanged += new System.EventHandler(this.CheckBoxCustomFileEnding_CheckedChanged);
            // 
            // textBoxBackupFileEnding
            // 
            this.textBoxBackupFileEnding.Location = new System.Drawing.Point(252, 130);
            this.textBoxBackupFileEnding.Name = "textBoxBackupFileEnding";
            this.textBoxBackupFileEnding.Size = new System.Drawing.Size(166, 20);
            this.textBoxBackupFileEnding.TabIndex = 12;
            // 
            // checkBoxBackupOnDbClose
            // 
            this.checkBoxBackupOnDbClose.AutoSize = true;
            this.checkBoxBackupOnDbClose.Location = new System.Drawing.Point(6, 110);
            this.checkBoxBackupOnDbClose.Name = "checkBoxBackupOnDbClose";
            this.checkBoxBackupOnDbClose.Size = new System.Drawing.Size(450, 17);
            this.checkBoxBackupOnDbClose.TabIndex = 13;
            this.checkBoxBackupOnDbClose.Text = "Backup Database when it\'s being closed or when the KeePass application is being c" +
    "losed";
            this.checkBoxBackupOnDbClose.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 408);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfBackups)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericNumberOfBackups;
        private System.Windows.Forms.CheckBox checkBoxUseDbName;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxUseRecycleBin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAutoBackup;
        private System.Windows.Forms.ListBox listBoxBackupPaths;
        private System.Windows.Forms.Button buttonRemoveSelectedFolder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDateFormatHelp;
        private System.Windows.Forms.TextBox textBoxDateFormat;
        private System.Windows.Forms.LinkLabel linkLabelReportBug;
        private System.Windows.Forms.LinkLabel linkLabelRessourcesOokiDialogsGitHub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBackupFileEnding;
        private System.Windows.Forms.CheckBox checkBoxCustomFileEnding;
        private System.Windows.Forms.CheckBox checkBoxBackupOnDbClose;
    }
}