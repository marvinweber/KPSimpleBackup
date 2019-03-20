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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSelectedBackupPath = new System.Windows.Forms.Label();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.numericNumberOfBackups = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSettingsIntro = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxUseDbName = new System.Windows.Forms.CheckBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxUseRecycleBin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfBackups)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.labelSettingsIntro);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 120);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.92252F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericNumberOfBackups, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 96);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.labelSelectedBackupPath);
            this.panel2.Controls.Add(this.buttonSelectFolder);
            this.panel2.Location = new System.Drawing.Point(153, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 56);
            this.panel2.TabIndex = 4;
            // 
            // labelSelectedBackupPath
            // 
            this.labelSelectedBackupPath.AutoSize = true;
            this.labelSelectedBackupPath.Location = new System.Drawing.Point(4, 33);
            this.labelSelectedBackupPath.Name = "labelSelectedBackupPath";
            this.labelSelectedBackupPath.Size = new System.Drawing.Size(29, 13);
            this.labelSelectedBackupPath.TabIndex = 3;
            this.labelSelectedBackupPath.Text = "Path";
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFolder.TabIndex = 2;
            this.buttonSelectFolder.Text = "Select folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // numericNumberOfBackups
            // 
            this.numericNumberOfBackups.Location = new System.Drawing.Point(153, 4);
            this.numericNumberOfBackups.Name = "numericNumberOfBackups";
            this.numericNumberOfBackups.Size = new System.Drawing.Size(120, 20);
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
            // labelSettingsIntro
            // 
            this.labelSettingsIntro.AutoSize = true;
            this.labelSettingsIntro.Location = new System.Drawing.Point(3, 5);
            this.labelSettingsIntro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelSettingsIntro.Name = "labelSettingsIntro";
            this.labelSettingsIntro.Size = new System.Drawing.Size(390, 13);
            this.labelSettingsIntro.TabIndex = 1;
            this.labelSettingsIntro.Text = "Please specify following options (at least the path is needed for backups to work" +
    "):";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(377, 177);
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
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(440, 159);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.checkBoxUseRecycleBin);
            this.tabPage2.Controls.Add(this.checkBoxUseDbName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 133);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 209);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfBackups)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSettingsIntro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSelectedBackupPath;
        private System.Windows.Forms.NumericUpDown numericNumberOfBackups;
        private System.Windows.Forms.CheckBox checkBoxUseDbName;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxUseRecycleBin;
        private System.Windows.Forms.Label label3;
    }
}