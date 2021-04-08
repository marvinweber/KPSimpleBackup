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
            this.checkBoxShowBackupFailedWarning = new System.Windows.Forms.CheckBox();
            this.textBoxRelativeBackupPath = new System.Windows.Forms.TextBox();
            this.buttonRelativeBackupPathHelp = new System.Windows.Forms.Button();
            this.buttonRelativeBackupPathAdd = new System.Windows.Forms.Button();
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
            linkLabelRessourcesOokiDialogsWebsite.Location = new System.Drawing.Point(54, 166);
            linkLabelRessourcesOokiDialogsWebsite.Name = "linkLabelRessourcesOokiDialogsWebsite";
            linkLabelRessourcesOokiDialogsWebsite.Size = new System.Drawing.Size(46, 13);
            linkLabelRessourcesOokiDialogsWebsite.TabIndex = 6;
            linkLabelRessourcesOokiDialogsWebsite.TabStop = true;
            linkLabelRessourcesOokiDialogsWebsite.Text = "Website";
            linkLabelRessourcesOokiDialogsWebsite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LinkLabelRessourcesOokiDialogsWebsite_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 398);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 392);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 336);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Additional settings:";
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
            this.numericNumberOfBackups.Location = new System.Drawing.Point(177, 4);
            this.numericNumberOfBackups.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNumberOfBackups.Name = "numericNumberOfBackups";
            this.numericNumberOfBackups.Size = new System.Drawing.Size(111, 20);
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
            this.panel2.Location = new System.Drawing.Point(177, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 255);
            this.panel2.TabIndex = 4;
            // 
            // buttonRemoveSelectedFolder
            // 
            this.buttonRemoveSelectedFolder.Enabled = false;
            this.buttonRemoveSelectedFolder.Location = new System.Drawing.Point(305, 3);
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
            this.listBoxBackupPaths.Location = new System.Drawing.Point(3, 30);
            this.listBoxBackupPaths.Name = "listBoxBackupPaths";
            this.listBoxBackupPaths.ScrollAlwaysVisible = true;
            this.listBoxBackupPaths.Size = new System.Drawing.Size(440, 225);
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
            this.label5.Location = new System.Drawing.Point(4, 300);
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
            this.panel3.Location = new System.Drawing.Point(177, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 28);
            this.panel3.TabIndex = 7;
            // 
            // buttonDateFormatHelp
            // 
            this.buttonDateFormatHelp.Location = new System.Drawing.Point(219, 4);
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
            this.textBoxDateFormat.Size = new System.Drawing.Size(210, 20);
            this.textBoxDateFormat.TabIndex = 0;
            this.textBoxDateFormat.TextChanged += new System.EventHandler(this.textBoxDateFormat_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBoxBackupKeePassConfig);
            this.panel4.Location = new System.Drawing.Point(176, 328);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 60);
            this.panel4.TabIndex = 9;
            // 
            // checkBoxBackupKeePassConfig
            // 
            this.checkBoxBackupKeePassConfig.AutoSize = true;
            this.checkBoxBackupKeePassConfig.Location = new System.Drawing.Point(4, 2);
            this.checkBoxBackupKeePassConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxBackupKeePassConfig.Name = "checkBoxBackupKeePassConfig";
            this.checkBoxBackupKeePassConfig.Size = new System.Drawing.Size(289, 17);
            this.checkBoxBackupKeePassConfig.TabIndex = 0;
            this.checkBoxBackupKeePassConfig.Text = "Backup KeePass configuration file (KeePass.config.xml)";
            this.checkBoxBackupKeePassConfig.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(587, 454);
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
            this.checkBoxUseDbName.Location = new System.Drawing.Point(10, 29);
            this.checkBoxUseDbName.Name = "checkBoxUseDbName";
            this.checkBoxUseDbName.Size = new System.Drawing.Size(483, 17);
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
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(650, 436);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(642, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxShowBackupFailedWarning);
            this.tabPage2.Controls.Add(this.textBoxRelativeBackupPath);
            this.tabPage2.Controls.Add(this.buttonRelativeBackupPathHelp);
            this.tabPage2.Controls.Add(this.buttonRelativeBackupPathAdd);
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
            this.tabPage2.Controls.Add(this.checkBoxUseRecycleBin);
            this.tabPage2.Controls.Add(this.checkBoxUseDbName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(642, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowBackupFailedWarning
            // 
            this.checkBoxShowBackupFailedWarning.AutoSize = true;
            this.checkBoxShowBackupFailedWarning.Location = new System.Drawing.Point(10, 99);
            this.checkBoxShowBackupFailedWarning.Name = "checkBoxShowBackupFailedWarning";
            this.checkBoxShowBackupFailedWarning.Size = new System.Drawing.Size(412, 17);
            this.checkBoxShowBackupFailedWarning.TabIndex = 28;
            this.checkBoxShowBackupFailedWarning.Text = "Show a popup-warning, if the backup fails or problems occured during the backup";
            this.checkBoxShowBackupFailedWarning.UseVisualStyleBackColor = true;
            // 
            // textBoxRelativeBackupPath
            // 
            this.textBoxRelativeBackupPath.Location = new System.Drawing.Point(10, 202);
            this.textBoxRelativeBackupPath.Name = "textBoxRelativeBackupPath";
            this.textBoxRelativeBackupPath.Size = new System.Drawing.Size(218, 20);
            this.textBoxRelativeBackupPath.TabIndex = 27;
            this.textBoxRelativeBackupPath.TextChanged += new System.EventHandler(this.textBoxRelativeBackupPath_TextChanged);
            // 
            // buttonRelativeBackupPathHelp
            // 
            this.buttonRelativeBackupPathHelp.Location = new System.Drawing.Point(380, 201);
            this.buttonRelativeBackupPathHelp.Name = "buttonRelativeBackupPathHelp";
            this.buttonRelativeBackupPathHelp.Size = new System.Drawing.Size(22, 21);
            this.buttonRelativeBackupPathHelp.TabIndex = 26;
            this.buttonRelativeBackupPathHelp.Text = "?";
            this.buttonRelativeBackupPathHelp.UseVisualStyleBackColor = true;
            this.buttonRelativeBackupPathHelp.Click += new System.EventHandler(this.buttonRelativeBackupPathHelp_Click);
            // 
            // buttonRelativeBackupPathAdd
            // 
            this.buttonRelativeBackupPathAdd.Enabled = false;
            this.buttonRelativeBackupPathAdd.Location = new System.Drawing.Point(233, 201);
            this.buttonRelativeBackupPathAdd.Name = "buttonRelativeBackupPathAdd";
            this.buttonRelativeBackupPathAdd.Size = new System.Drawing.Size(141, 21);
            this.buttonRelativeBackupPathAdd.TabIndex = 25;
            this.buttonRelativeBackupPathAdd.Text = "Add relative backup path";
            this.buttonRelativeBackupPathAdd.UseVisualStyleBackColor = true;
            this.buttonRelativeBackupPathAdd.Click += new System.EventHandler(this.buttonRelativeBackupPathAdd_Click);
            // 
            // numericUpDownLtbYearly
            // 
            this.numericUpDownLtbYearly.Location = new System.Drawing.Point(263, 381);
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
            this.numericUpDownLtbYearly.Size = new System.Drawing.Size(111, 20);
            this.numericUpDownLtbYearly.TabIndex = 24;
            this.numericUpDownLtbYearly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLtbMonthly
            // 
            this.numericUpDownLtbMonthly.Location = new System.Drawing.Point(263, 355);
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
            this.numericUpDownLtbMonthly.Size = new System.Drawing.Size(111, 20);
            this.numericUpDownLtbMonthly.TabIndex = 23;
            this.numericUpDownLtbMonthly.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLtbWeekly
            // 
            this.numericUpDownLtbWeekly.Location = new System.Drawing.Point(263, 329);
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
            this.numericUpDownLtbWeekly.Size = new System.Drawing.Size(111, 20);
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
            this.label14.Location = new System.Drawing.Point(30, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Amount of yearly backups to keep (years):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Amount of monthly backups to keep (months):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amount of weekly backups to keep (weeks):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(612, 39);
            this.label11.TabIndex = 18;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Long-Term-Backups";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Advanced Backup-Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "General Backup-Options";
            // 
            // checkBoxEnableLongTermBackups
            // 
            this.checkBoxEnableLongTermBackups.AutoSize = true;
            this.checkBoxEnableLongTermBackups.Location = new System.Drawing.Point(12, 306);
            this.checkBoxEnableLongTermBackups.Name = "checkBoxEnableLongTermBackups";
            this.checkBoxEnableLongTermBackups.Size = new System.Drawing.Size(158, 17);
            this.checkBoxEnableLongTermBackups.TabIndex = 14;
            this.checkBoxEnableLongTermBackups.Text = "Enable Long-Term-Backups";
            this.checkBoxEnableLongTermBackups.UseVisualStyleBackColor = true;
            this.checkBoxEnableLongTermBackups.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLongTermBackups_CheckedChanged);
            // 
            // checkBoxBackupOnDbClose
            // 
            this.checkBoxBackupOnDbClose.AutoSize = true;
            this.checkBoxBackupOnDbClose.Location = new System.Drawing.Point(10, 177);
            this.checkBoxBackupOnDbClose.Name = "checkBoxBackupOnDbClose";
            this.checkBoxBackupOnDbClose.Size = new System.Drawing.Size(612, 17);
            this.checkBoxBackupOnDbClose.TabIndex = 13;
            this.checkBoxBackupOnDbClose.Text = "Backup Database on Close (new backup is created whenever the database is closed/l" +
    "ocked; also when KeePass is closed)";
            this.checkBoxBackupOnDbClose.UseVisualStyleBackColor = true;
            // 
            // textBoxBackupFileEnding
            // 
            this.textBoxBackupFileEnding.Location = new System.Drawing.Point(317, 154);
            this.textBoxBackupFileEnding.Name = "textBoxBackupFileEnding";
            this.textBoxBackupFileEnding.Size = new System.Drawing.Size(145, 20);
            this.textBoxBackupFileEnding.TabIndex = 12;
            // 
            // checkBoxCustomFileEnding
            // 
            this.checkBoxCustomFileEnding.AutoSize = true;
            this.checkBoxCustomFileEnding.Location = new System.Drawing.Point(10, 154);
            this.checkBoxCustomFileEnding.Name = "checkBoxCustomFileEnding";
            this.checkBoxCustomFileEnding.Size = new System.Drawing.Size(274, 17);
            this.checkBoxCustomFileEnding.TabIndex = 11;
            this.checkBoxCustomFileEnding.Text = "Use custom File-Ending (Extension) for Backup-Files:";
            this.checkBoxCustomFileEnding.UseVisualStyleBackColor = true;
            this.checkBoxCustomFileEnding.CheckedChanged += new System.EventHandler(this.CheckBoxCustomFileEnding_CheckedChanged);
            // 
            // checkBoxAutoBackup
            // 
            this.checkBoxAutoBackup.AutoSize = true;
            this.checkBoxAutoBackup.Location = new System.Drawing.Point(10, 76);
            this.checkBoxAutoBackup.Name = "checkBoxAutoBackup";
            this.checkBoxAutoBackup.Size = new System.Drawing.Size(452, 17);
            this.checkBoxAutoBackup.TabIndex = 10;
            this.checkBoxAutoBackup.Text = "Backup Database on Save (new backup is created, whenever the dabase is being save" +
    "d)";
            this.checkBoxAutoBackup.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseRecycleBin
            // 
            this.checkBoxUseRecycleBin.AutoSize = true;
            this.checkBoxUseRecycleBin.Location = new System.Drawing.Point(10, 53);
            this.checkBoxUseRecycleBin.Name = "checkBoxUseRecycleBin";
            this.checkBoxUseRecycleBin.Size = new System.Drawing.Size(586, 17);
            this.checkBoxUseRecycleBin.TabIndex = 8;
            this.checkBoxUseRecycleBin.Text = "Use Recycle Bin (enabling this option moves cleaned up backup files to the trash " +
    "instead of permanently deleting them)";
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
            this.tabPage3.Size = new System.Drawing.Size(642, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 489);
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
        private System.Windows.Forms.TextBox textBoxRelativeBackupPath;
        private System.Windows.Forms.Button buttonRelativeBackupPathHelp;
        private System.Windows.Forms.Button buttonRelativeBackupPathAdd;
        private System.Windows.Forms.CheckBox checkBoxShowBackupFailedWarning;
    }
}