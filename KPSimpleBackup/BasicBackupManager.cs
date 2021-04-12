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

        /// <summary>
        /// Path to the last backup file of the database that has
        /// been created by this backup manager.
        /// </summary>
        public string lastBackupFilePath = null;

        public BasicBackupManager(PwDatabase database) : base(database)
        {
            //
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
            string time = GenerateUserConfiguredTimeString();
            string path = FILE_PREFIX + basePath + dbFileName + "_" + time + dbFileExtension;
            SavePwDatabaseToPath(path);
            lastBackupFilePath = path;
        }

        protected override void Cleanup()
        {
            base.Cleanup();

            string cleanupSearchPattern = dbFileName + "_*" + dbFileExtension;
            CleanupManager.Cleanup(basePath, cleanupSearchPattern, database.IOConnectionInfo.Path);
        }
    }
}
