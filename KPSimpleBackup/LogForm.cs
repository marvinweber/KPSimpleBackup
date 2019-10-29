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
    public partial class LogForm : Form
    {
        private Logger logger;

        public LogForm(Logger logger)
        {
            this.logger = logger;

            InitializeComponent();

            listBoxLog.DataSource = this.logger.GetLog();
        }

        private void ButtonCopyAllEntries_Click(object sender, EventArgs e)
        {
            // set all items selected
            for (int i = 0; i < listBoxLog.Items.Count; i++)
            {
                listBoxLog.SetSelected(i, true);
            }
            // copy them to clipboard
            this.CopySelectedLogItemsToClipboard();
        }

        private void ButtonCopySelectedEntries_Click(object sender, EventArgs e)
        {
            this.CopySelectedLogItemsToClipboard();
        }

        private void CopySelectedLogItemsToClipboard()
        {
            string s = "";
            foreach (object o in listBoxLog.SelectedItems)
            {
                s += o.ToString() + "\r\n";
            }
            Clipboard.SetText(s);
        }
    }
}
