
using KeePass.Resources;
using KeePassLib;
using KeePassLib.Interfaces;
using KeePassLib.Serialization;
using KeePassLib.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace KPSimpleBackup
{
    public abstract class BackupManager
    {

        protected const string FILE_PREFIX = "file:///";
        private const string DEFAULT_BACKUP_FILE_EXTENSION = ".kdbx";

        protected virtual string ManagerName { get; set; }

        protected static KPSimpleBackupConfig config;

        protected PwDatabase database;

        protected string dbFileExtension;

        protected string dbFileName;

        protected string basePath;

        protected static Logger pluginLogger = null;

        /// <summary>
        /// Logger used by the MainWindows of KeePass to show current status
        /// of saving process.
        /// </summary>
        protected static IStatusLogger KPMainWindowSwLogger = null;

        public BackupManager(PwDatabase database)
        {
            this.database = database;
            this.dbFileExtension = GetDbFileExtension();
            this.dbFileName = GetBackupFileName(database);
        }

        public static void SetPluginLogger(Logger logger)
        {
            pluginLogger = logger;
        }

        /// <summary>
        /// Set the logger that should be used for saving databases. This should
        /// be the logger created by the main KeePass application.
        /// </summary>
        /// <param name="logger">Logger to use while saving databases.</param>
        public static void SetKPMainWindowSwLogger(KeePassLib.Interfaces.IStatusLogger logger)
        {
            KPMainWindowSwLogger = logger;
        }

        /// <summary>
        /// Set KPSimpleBackupConfig to use.
        /// </summary>
        /// <param name="config">Configuration that should be used.</param>
        public static void SetConfig(KPSimpleBackupConfig config)
        {
            BackupManager.config = config;
        }

        /// <summary>
        /// Run the actual BackupManager based on the prior
        /// defined settings / using the prior set database.
        /// Backups will be created in each backup-directory
        /// saved in the KPSimpleBackupConfig.
        /// </summary>
        /// <returns>If the operation completed successfully without warnings</returns>
        public bool Run()
        {
            pluginLogger.Log("START BackupManager: " + ManagerName + " for database: " + database.Name, LogStatusType.Info);
            bool warning = false;

            List<string> paths = config.BackupPath;
            foreach (string backupFolderPath in paths)
            {
                try
                {
                    // ensure (possible stored) relative path is converted to an absolute one
                    basePath = UrlUtil.EnsureTerminatingSeparator(
                        UrlUtil.MakeAbsolutePath(database.IOConnectionInfo.Path, backupFolderPath),
                        false
                    );
                    pluginLogger.Log("Backup to next path: " + basePath, LogStatusType.Info);

                    PreBackup();
                    Backup();
                    Cleanup();
                }
                catch (Exception e)
                {
                    warning = true;
                    pluginLogger.Log("BackupManager (" + ManagerName + ") finished with warnings!", LogStatusType.AdditionalInfo);
                    pluginLogger.Log("Exception: " + e.ToString(), LogStatusType.AdditionalInfo);
                }
            }

            pluginLogger.Log("FINISHED BackupManager: " + ManagerName, LogStatusType.Info);
            return ! warning;
        }

        protected abstract void PreBackup();
        protected abstract void Backup();
        protected abstract void Cleanup();

        protected void SavePwDatabaseToPath(IOConnectionInfo fileInfo)
        {
            pluginLogger.Log("Save database to: " + fileInfo.Path, LogStatusType.Info);
            KPMainWindowSwLogger.StartLogging(KPRes.SavingDatabase, true);
            database.SaveAs(fileInfo, false, KPMainWindowSwLogger);
            KPMainWindowSwLogger.EndLogging();
        }

        protected void SavePwDatabaseToPath(string path)
        {
            SavePwDatabaseToPath(IOConnectionInfo.FromPath(path));
        }

        /// <summary>
        /// Generate the file extension that should be used.
        /// If no custom extension is set, the current db-extension
        /// is used, as a fallback the "standard" file extension
        /// is used.
        /// </summary>
        /// <returns>The database extension to use</returns>
        private string GetDbFileExtension()
        {
            string databaseExtension = DEFAULT_BACKUP_FILE_EXTENSION;
            try
            {
                if (config.UseCustomBackupFileExtension)
                {
                    databaseExtension = config.BackupFileExtension;
                }
                else
                {
                    string databasePath = database.IOConnectionInfo.Path;
                    databaseExtension = Path.GetExtension(databasePath);
                }
            }
            catch (Exception) { }
            return databaseExtension;
        }

        private string GetBackupFileName(PwDatabase database)
        {
            // start with database name as 'fallback' / default
            string backupFileName = database.Name;

            // get file name if database name shouldn't be used
            if (! config.UseDatabaseNameForBackupFiles)
            {
                string path = database.IOConnectionInfo.Path;
                backupFileName = Path.GetFileNameWithoutExtension(path);
            }

            return backupFileName;
        }

    }
}
