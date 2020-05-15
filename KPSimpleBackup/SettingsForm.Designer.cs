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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxBackupKeePassConfig = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxUseDbName = new System.Windows.Forms.CheckBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDownLtbYearly = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLtbMonthly = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLtbWeekly = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxEnableLongTermBackups = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupOnDbClose = new System.Windows.Forms.CheckBox();
            this.textBoxBackupFileEnding = new System.Windows.Forms.TextBox();
            this.checkBoxCustomFileEnding = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoBackup = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUseRecycleBin = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabelRessourcesOokiDialogsGitHub = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabelReportBug = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            linkLabelRessourcesOokiDialogsWebsite = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfBackups)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLtbYearly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLtbMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLtbWeekly)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelRessourcesOokiDialogsWebsite
            // 
            linkLabelRessourcesOokiDialogsWebsite.ActiveLinkColor = System.Drawing.Color.DarkRed;
            linkLabelRessourcesOokiDialogsWebsite.AutoSize = true;
            linkLabelRessourcesOokiDialogsWebsite.LinkColor = System.Drawing.Color.DarkRed;
            linkLabelRessourcesOokiDialogsWebsite.Location = new System.Drawing.Point(72, 204);
            linkLabelRessourcesOokiDialogsWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabelRessourcesOokiDialogsWebsite.Name = "linkLabelRessourcesOokiDialogsWebsite";
            linkLabelRessourcesOokiDialogsWebsite.Size = new System.Drawing.Size(59, 17);
            linkLabelRessourcesOokiDialogsWebsite.TabIndex = 6;
            linkLabelRessourcesOokiDialogsWebsite.TabStop = true;
            linkLabelRessourcesOokiDialogsWebsite.Text = "Website";
            linkLabelRessourcesOokiDialogsWebsite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LinkLabelRessourcesOokiDialogsWebsite_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 490);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36422F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericNumberOfBackups, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 3);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 482);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 413);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Additional settings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of backups to keep:";
            // 
            // numericNumberOfBackups
            // 
            this.numericNumberOfBackups.Location = new System.Drawing.Point(236, 5);
            this.numericNumberOfBackups.Margin = new System.Windows.Forms.Padding(4);
            this.numericNumberOfBackups.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNumberOfBackups.Name = "numericNumberOfBackups";
            this.numericNumberOfBackups.Size = new System.Drawing.Size(148, 22);
            this.numericNumberOfBackups.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 18, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder for backup files:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRemoveSelectedFolder);
            this.panel2.Controls.Add(this.listBoxBackupPaths);
            this.panel2.Controls.Add(this.buttonAddFolder);
            this.panel2.Location = new System.Drawing.Point(236, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 316);
            this.panel2.TabIndex = 4;
            // 
            // buttonRemoveSelectedFolder
            // 
            this.buttonRemoveSelectedFolder.Enabled = false;
            this.buttonRemoveSelectedFolder.Location = new System.Drawing.Point(407, 4);
            this.buttonRemoveSelectedFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveSelectedFolder.Name = "buttonRemoveSelectedFolder";
            this.buttonRemoveSelectedFolder.Size = new System.Drawing.Size(184, 28);
            this.buttonRemoveSelectedFolder.TabIndex = 5;
            this.buttonRemoveSelectedFolder.Text = "Remove selected folder";
            this.buttonRemoveSelectedFolder.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedFolder.Click += new System.EventHandler(this.buttonRemoveSelectedFolder_Click);
            // 
            // listBoxBackupPaths
            // 
            this.listBoxBackupPaths.FormattingEnabled = true;
            this.listBoxBackupPaths.HorizontalScrollbar = true;
            this.listBoxBackupPaths.ItemHeight = 16;
            this.listBoxBackupPaths.Location = new System.Drawing.Point(4, 37);
            this.listBoxBackupPaths.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxBackupPaths.Name = "listBoxBackupPaths";
            this.listBoxBackupPaths.ScrollAlwaysVisible = true;
            this.listBoxBackupPaths.Size = new System.Drawing.Size(585, 276);
            this.listBoxBackupPaths.TabIndex = 4;
            this.listBoxBackupPaths.SelectedIndexChanged += new System.EventHandler(this.listBoxBackupPaths_SelectedIndexChanged);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(4, 4);
            this.buttonAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(100, 28);
            this.buttonAddFolder.TabIndex = 2;
            this.buttonAddFolder.Text = "Add folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date format:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDateFormatHelp);
            this.panel3.Controls.Add(this.textBoxDateFormat);
            this.panel3.Location = new System.Drawing.Point(236, 361);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 35);
            this.panel3.TabIndex = 7;
            // 
            // buttonDateFormatHelp
            // 
            this.buttonDateFormatHelp.Location = new System.Drawing.Point(292, 5);
            this.buttonDateFormatHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDateFormatHelp.Name = "buttonDateFormatHelp";
            this.buttonDateFormatHelp.Size = new System.Drawing.Size(27, 25);
            this.buttonDateFormatHelp.TabIndex = 1;
            this.buttonDateFormatHelp.Text = "?";
            this.buttonDateFormatHelp.UseVisualStyleBackColor = true;
            this.buttonDateFormatHelp.Click += new System.EventHandler(this.buttonDateFormatHelp_Click);
            // 
            // textBoxDateFormat
            // 
            this.textBoxDateFormat.Location = new System.Drawing.Point(4, 5);
            this.textBoxDateFormat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDateFormat.Name = "textBoxDateFormat";
            this.textBoxDateFormat.Size = new System.Drawing.Size(279, 22);
            this.textBoxDateFormat.TabIndex = 0;
            this.textBoxDateFormat.TextChanged += new System.EventHandler(this.textBoxDateFormat_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBoxBackupKeePassConfig);
            this.panel4.Location = new System.Drawing.Point(235, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 74);
            this.panel4.TabIndex = 9;
            // 
            // checkBoxBackupKeePassConfig
            // 
            this.checkBoxBackupKeePassConfig.AutoSize = true;
            this.checkBoxBackupKeePassConfig.Location = new System.Drawing.Point(5, 3);
            this.checkBoxBackupKeePassConfig.Name = "checkBoxBackupKeePassConfig";
            this.checkBoxBackupKeePassConfig.Size = new System.Drawing.Size(430, 21);
            this.checkBoxBackupKeePassConfig.TabIndex = 0;
            this.checkBoxBackupKeePassConfig.Text = "Backup KeePass configuration file (KeePass.config.xml) - BETA";
            this.checkBoxBackupKeePassConfig.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(783, 559);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 28);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxUseDbName
            // 
            this.checkBoxUseDbName.AutoSize = true;
            this.checkBoxUseDbName.Location = new System.Drawing.Point(13, 81);
            this.checkBoxUseDbName.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUseDbName.Name = "checkBoxUseDbName";
            this.checkBoxUseDbName.Size = new System.Drawing.Size(646, 21);
            this.checkBoxUseDbName.TabIndex = 7;
            this.checkBoxUseDbName.Text = "Use database name (File -> Database-Settings -> Name) instead of file name as bac" +
    "kup file name";
            this.checkBoxUseDbName.UseVisualStyleBackColor = true;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Controls.Add(this.tabPage3);
            this.tabControlSettings.Location = new System.Drawing.Point(16, 15);
            this.tabControlSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(867, 537);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(859, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownLtbYearly);
            this.tabPage2.Controls.Add(this.numericUpDownLtbMonthly);
            this.tabPage2.Controls.Add(this.numericUpDownLtbWeekly);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.checkBoxEnableLongTermBackups);
            this.tabPage2.Controls.Add(this.checkBoxBackupOnDbClose);
            this.tabPage2.Controls.Add(this.textBoxBackupFileEnding);
            this.tabPage2.Controls.Add(this.checkBoxCustomFileEnding);
            this.tabPage2.Controls.Add(this.checkBoxAutoBackup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.checkBoxUseRecycleBin);
            this.tabPage2.Controls.Add(this.checkBoxUseDbName);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(859, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLtbYearly
            // 
            this.numericUpDownLtbYearly.Location = new System.Drawing.Point(351, 469);
            this.numericUpDownLtbYearly.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownLtbYearly.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLtbYearly.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLtbYearly.Name = "numericUpDownLtbYearly";
            this.numericUpDownLtbYearly.Size = new System.Drawing.Size(148, 22);
            this.numericUpDownLtbYearly.TabIndex = 24;
            this.numericUpDownLtbYearly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLtbMonthly
            // 
            this.numericUpDownLtbMonthly.Location = new System.Drawing.Point(351, 437);
            this.numericUpDownLtbMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownLtbMonthly.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLtbMonthly.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLtbMonthly.Name = "numericUpDownLtbMonthly";
            this.numericUpDownLtbMonthly.Size = new System.Drawing.Size(148, 22);
            this.numericUpDownLtbMonthly.TabIndex = 23;
            this.numericUpDownLtbMonthly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLtbWeekly
            // 
            this.numericUpDownLtbWeekly.Location = new System.Drawing.Point(351, 405);
            this.numericUpDownLtbWeekly.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownLtbWeekly.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLtbWeekly.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLtbWeekly.Name = "numericUpDownLtbWeekly";
            this.numericUpDownLtbWeekly.Size = new System.Drawing.Size(148, 22);
            this.numericUpDownLtbWeekly.TabIndex = 22;
            this.numericUpDownLtbWeekly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 471);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Amount of yearly backups to keep (years):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 439);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Amount of monthly backups to keep (months):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 407);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amount of weekly backups to keep (weeks):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 319);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(818, 51);
            this.label11.TabIndex = 18;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 289);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Long-Term-Backups";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Advanced Backup-Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "General Backup-Options";
            // 
            // checkBoxEnableLongTermBackups
            // 
            this.checkBoxEnableLongTermBackups.AutoSize = true;
            this.checkBoxEnableLongTermBackups.Location = new System.Drawing.Point(16, 377);
            this.checkBoxEnableLongTermBackups.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEnableLongTermBackups.Name = "checkBoxEnableLongTermBackups";
            this.checkBoxEnableLongTermBackups.Size = new System.Drawing.Size(207, 21);
            this.checkBoxEnableLongTermBackups.TabIndex = 14;
            this.checkBoxEnableLongTermBackups.Text = "Enable Long-Term-Backups";
            this.checkBoxEnableLongTermBackups.UseVisualStyleBackColor = true;
            this.checkBoxEnableLongTermBackups.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLongTermBackups_CheckedChanged);
            // 
            // checkBoxBackupOnDbClose
            // 
            this.checkBoxBackupOnDbClose.AutoSize = true;
            this.checkBoxBackupOnDbClose.Location = new System.Drawing.Point(13, 240);
            this.checkBoxBackupOnDbClose.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxBackupOnDbClose.Name = "checkBoxBackupOnDbClose";
            this.checkBoxBackupOnDbClose.Size = new System.Drawing.Size(592, 21);
            this.checkBoxBackupOnDbClose.TabIndex = 13;
            this.checkBoxBackupOnDbClose.Text = "Backup Database when it\'s being closed or when the KeePass application is being c" +
    "losed";
            this.checkBoxBackupOnDbClose.UseVisualStyleBackColor = true;
            // 
            // textBoxBackupFileEnding
            // 
            this.textBoxBackupFileEnding.Location = new System.Drawing.Point(420, 208);
            this.textBoxBackupFileEnding.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBackupFileEnding.Name = "textBoxBackupFileEnding";
            this.textBoxBackupFileEnding.Size = new System.Drawing.Size(192, 22);
            this.textBoxBackupFileEnding.TabIndex = 12;
            // 
            // checkBoxCustomFileEnding
            // 
            this.checkBoxCustomFileEnding.AutoSize = true;
            this.checkBoxCustomFileEnding.Location = new System.Drawing.Point(13, 212);
            this.checkBoxCustomFileEnding.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCustomFileEnding.Name = "checkBoxCustomFileEnding";
            this.checkBoxCustomFileEnding.Size = new System.Drawing.Size(398, 21);
            this.checkBoxCustomFileEnding.TabIndex = 11;
            this.checkBoxCustomFileEnding.Text = "Always use custom file-ending (extension) for backup-files:";
            this.checkBoxCustomFileEnding.UseVisualStyleBackColor = true;
            this.checkBoxCustomFileEnding.CheckedChanged += new System.EventHandler(this.CheckBoxCustomFileEnding_CheckedChanged);
            // 
            // checkBoxAutoBackup
            // 
            this.checkBoxAutoBackup.AutoSize = true;
            this.checkBoxAutoBackup.Location = new System.Drawing.Point(13, 138);
            this.checkBoxAutoBackup.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoBackup.Name = "checkBoxAutoBackup";
            this.checkBoxAutoBackup.Size = new System.Drawing.Size(569, 21);
            this.checkBoxAutoBackup.TabIndex = 10;
            this.checkBoxAutoBackup.Text = "Auto-Backup Database (backup will be created, everytime the dabase is being saved" +
    ")";
            this.checkBoxAutoBackup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "You should only change settings here, if you know what you are doing ;)";
            // 
            // checkBoxUseRecycleBin
            // 
            this.checkBoxUseRecycleBin.AutoSize = true;
            this.checkBoxUseRecycleBin.Location = new System.Drawing.Point(13, 110);
            this.checkBoxUseRecycleBin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUseRecycleBin.Name = "checkBoxUseRecycleBin";
            this.checkBoxUseRecycleBin.Size = new System.Drawing.Size(651, 21);
            this.checkBoxUseRecycleBin.TabIndex = 8;
            this.checkBoxUseRecycleBin.Text = "Use Recycle Bin (instead of completeley removing old backup files, they will be m" +
    "oved to the trash)";
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(859, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabelRessourcesOokiDialogsGitHub
            // 
            this.linkLabelRessourcesOokiDialogsGitHub.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelRessourcesOokiDialogsGitHub.AutoSize = true;
            this.linkLabelRessourcesOokiDialogsGitHub.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelRessourcesOokiDialogsGitHub.Location = new System.Drawing.Point(11, 204);
            this.linkLabelRessourcesOokiDialogsGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelRessourcesOokiDialogsGitHub.Name = "linkLabelRessourcesOokiDialogsGitHub";
            this.linkLabelRessourcesOokiDialogsGitHub.Size = new System.Drawing.Size(52, 17);
            this.linkLabelRessourcesOokiDialogsGitHub.TabIndex = 5;
            this.linkLabelRessourcesOokiDialogsGitHub.TabStop = true;
            this.linkLabelRessourcesOokiDialogsGitHub.Text = "GitHub";
            this.linkLabelRessourcesOokiDialogsGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRessourcesOokiDialogsGitHub_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(515, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ookii.Dialogs.WinForms - Copyright (c) Sven Groot (Ookii.org) 2009";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Open source software used in KPSimpleBackup";
            // 
            // linkLabelReportBug
            // 
            this.linkLabelReportBug.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelReportBug.AutoSize = true;
            this.linkLabelReportBug.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelReportBug.Location = new System.Drawing.Point(11, 79);
            this.linkLabelReportBug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelReportBug.Name = "linkLabelReportBug";
            this.linkLabelReportBug.Size = new System.Drawing.Size(80, 17);
            this.linkLabelReportBug.TabIndex = 2;
            this.linkLabelReportBug.TabStop = true;
            this.linkLabelReportBug.Text = "Report Bug";
            this.linkLabelReportBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReportBug_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(11, 48);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(56, 17);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "KPSimpleBackup";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 602);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLtbYearly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLtbMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLtbWeekly)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBoxEnableLongTermBackups;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownLtbYearly;
        private System.Windows.Forms.NumericUpDown numericUpDownLtbMonthly;
        private System.Windows.Forms.NumericUpDown numericUpDownLtbWeekly;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBoxBackupKeePassConfig;
    }
}