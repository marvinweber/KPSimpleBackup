using KeePassLib.Interfaces;
using KeePassLib.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace KPSimpleBackup
{
    public class Logger
    {
        private const string LOG_FILE_NAME = "kpsimplebackup.log.txt";

        private List<string> currentLog;
        private StreamWriter streamWriter;
        private bool writeToFile;

        public Logger(bool writeToFile)
        {
            currentLog = new List<string>();

            this.writeToFile = writeToFile;
            if (writeToFile)
            {
                string path = UrlUtil.EnsureTerminatingSeparator(KeePass.App.Configuration.AppConfigSerializer.AppDataDirectory, false);
                Directory.CreateDirectory(path);
                streamWriter = File.AppendText(path + LOG_FILE_NAME);
            }
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
            StoreLine("[KPSimpleBackup] [" + lsType + "] " + text);
        }

        public void Terminate()
        {
            if (writeToFile)
            {
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void StoreLine(string text)
        {
            string line = "[" + DateTime.Now.ToString() + "] " + text;

            currentLog.Add(line);
            if (writeToFile)
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}
