using KeePassLib.Interfaces;
using System;
using System.Collections.Generic;

namespace KPSimpleBackup
{
    public class Logger : IStatusLogger
    {
        private KPSimpleBackupConfig config;
        private List<string> currentLog;
        private string currentOperation;
        private bool writeOperationToLog;

        public Logger(KPSimpleBackupConfig config)
        {
            this.config = config;
            this.currentLog = new List<string>();
        }

        public bool ContinueWork()
        {
            throw new System.NotImplementedException();
        }

        public void EndLogging()
        {
            this.StoreLine("OPERATION FINISHED: " + this.currentOperation);
            this.currentOperation = "";
            this.writeOperationToLog = false;
        }

        public bool SetProgress(uint uPercent)
        {
            this.StoreLine("New Progress: " + uPercent);
            return true;
        }

        public bool SetText(string strNewText, LogStatusType lsType)
        {
            this.StoreLine(strNewText);
            return true;
        }

        public void StartLogging(string strOperation, bool bWriteOperationToLog)
        {
            this.writeOperationToLog = bWriteOperationToLog;
            this.currentOperation = strOperation;
            this.StoreLine("OPERATION STARTED: " + this.currentOperation);
        }

        public List<string> GetLog()
        {
            return this.currentLog;
        }

        /// <summary>
        /// Log function for the KPSimpleBackup plugin. It should be used only
        /// by KPSimpleBackup, since it puts the plugin name in front of each
        /// log line.
        /// </summary>
        /// <param name="text">Text that will be logged</param>
        /// <param name="lsType">Status Type</param>
        public void Log(string text, LogStatusType lsType)
        {
            this.StoreLine("[KPSimpleBackup] [" + lsType + "] " + text);
        }

        private void StoreLine(string line)
        {
            this.currentLog.Add("[" + DateTime.Now.ToString() + "] " + line);
        }
    }
}
