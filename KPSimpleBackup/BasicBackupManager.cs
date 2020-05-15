using KeePass.Plugins;
using KeePassLib;
using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

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
            try
            {
                Directory.CreateDirectory(basePath);
            }
            catch (Exception e)
            {
                pluginLogger.Log("Could not create backup directory!", KeePassLib.Interfaces.LogStatusType.Error);
                pluginLogger.Log("Exception: " + e.ToString(), KeePassLib.Interfaces.LogStatusType.AdditionalInfo);
                throw e;
            }
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
