using KeePassLib;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSimpleBackup
{
    class BasicBackupManager : BackupManager
    {
        protected override string ManagerName { get { return "BasicBackup"; } }

        private string time;

        public BasicBackupManager(PwDatabase database) : base(database)
        {
            string dateTimeFormat = config.DateFormat;
            time = DateTime.Now.ToString(dateTimeFormat);
        }

        protected override void PreBackup()
        {
            //
        }

        protected override void Backup()
        {
            string path = FILE_PREFIX + basePath + dbFileName + "_" + time + dbFileExtension;
            SavePwDatabaseToPath(path);
        }

        protected override void Cleanup()
        {
            string cleanupSearchPattern = dbFileName + "_*" + dbFileExtension;
            this.CleanupBasic(basePath, cleanupSearchPattern, database.IOConnectionInfo.Path);
        }

        private void CleanupBasic(String path, String searchPattern, String originalDatabasePath)
        {
            int filesToKeepAmount = (int) config.FileAmountToKeep;
            // read from settings whether to use recycle bin or delete files permanently
            var recycleOption = config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;

            String[] fileList = Directory.GetFiles(path, searchPattern).OrderBy(f => f).Reverse().ToArray();

            // if more backup files available than needed loop through the unnecessary ones and remove them
            if (fileList.Count() > filesToKeepAmount)
            {
                for (int i = filesToKeepAmount; i < fileList.Count(); i++)
                {
                    // never delete original file -> always skip it (in case it made it in the filelist)
                    if (fileList[i].Equals(originalDatabasePath))
                    {
                        continue;
                    }

                    FileSystem.DeleteFile(fileList[i], UIOption.OnlyErrorDialogs, recycleOption);
                }
            }
        }
    }
}
