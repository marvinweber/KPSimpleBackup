using KeePassLib;
using Microsoft.VisualBasic.FileIO;
using System;

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
            RecycleOption recycleOption = config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;
            CleanupManager.Cleanup(basePath, cleanupSearchPattern, database.IOConnectionInfo.Path, (int) config.FileAmountToKeep, recycleOption);
        }
    }
}
