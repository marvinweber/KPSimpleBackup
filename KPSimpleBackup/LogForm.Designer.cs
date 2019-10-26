namespace KPSimpleBackup
{
    partial class LogForm
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
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.buttonCopyAllEntries = new System.Windows.Forms.Button();
            this.buttonCopySelectedEntries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 8);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLog.Size = new System.Drawing.Size(1033, 524);
            this.listBoxLog.TabIndex = 0;
            // 
            // buttonCopyAllEntries
            // 
            this.buttonCopyAllEntries.Location = new System.Drawing.Point(892, 543);
            this.buttonCopyAllEntries.Name = "buttonCopyAllEntries";
            this.buttonCopyAllEntries.Size = new System.Drawing.Size(153, 23);
            this.buttonCopyAllEntries.TabIndex = 1;
            this.buttonCopyAllEntries.Text = "Copy all entries to clipboard";
            this.buttonCopyAllEntries.UseVisualStyleBackColor = true;
            this.buttonCopyAllEntries.Click += new System.EventHandler(this.ButtonCopyAllEntries_Click);
            // 
            // buttonCopySelectedEntries
            // 
            this.buttonCopySelectedEntries.Location = new System.Drawing.Point(698, 543);
            this.buttonCopySelectedEntries.Name = "buttonCopySelectedEntries";
            this.buttonCopySelectedEntries.Size = new System.Drawing.Size(188, 23);
            this.buttonCopySelectedEntries.TabIndex = 2;
            this.buttonCopySelectedEntries.Text = "Copy selected entries to clipboard";
            this.buttonCopySelectedEntries.UseVisualStyleBackColor = true;
            this.buttonCopySelectedEntries.Click += new System.EventHandler(this.ButtonCopySelectedEntries_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 578);
            this.Controls.Add(this.buttonCopySelectedEntries);
            this.Controls.Add(this.buttonCopyAllEntries);
            this.Controls.Add(this.listBoxLog);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Session Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonCopyAllEntries;
        private System.Windows.Forms.Button buttonCopySelectedEntries;
    }
}