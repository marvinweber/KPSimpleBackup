
using KeePass.Resources;
using KeePassLib;
using KeePassLib.Interfaces;
using KeePassLib.Serialization;
using KeePassLib.Utility;
using Microsoft.VisualBasic.FileIO;
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
        /// A path to a temporary copy of the database file.
        /// </summary>
        private string tempDatabaseBackupFile = null;

        /// <summary>
        /// List of temporary created files, that will be removed in the
        /// cleanup again.
        /// </summary>
        private List<string> temporaryFiles;

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
            this.temporaryFiles = new List<string>();
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
        /// Set a path to a file that can be temporarly used by this backup
        /// manager for copying it as new backup (for LTB backups, for instance).
        /// The file will not be deleted or modified in any way.
        /// </summary>
        /// <param name="tempDatabaseBackupFile">path to the database file</param>
        public void SetTempDatabaseBackupFile(string tempDatabaseBackupFile)
        {
            this.tempDatabaseBackupFile = tempDatabaseBackupFile;
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

        /// <summary>
        /// Delete all temporary created files.
        /// Can be overwritten by child classes to implement/ extend by
        /// their own cleanup logic.
        /// </summary>
        protected virtual void Cleanup()
        {
            foreach (string tempFile in temporaryFiles)
            {
                pluginLogger.Log("Deleting temporary file: " + tempFile, LogStatusType.Info);
                FileSystem.DeleteFile(new Uri(tempFile).LocalPath);
            }
        }

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
        /// Copy the file of the currently opened database to a
        /// given destination path.
        /// </summary>
        /// <param name="toPath">
        /// Full path (including file name + extension) where the
        /// database file should be copied to.
        /// </param>
        /// <param name="overwrite">
        /// Whether to overwrite a possible conflicting destination
        /// file, or not.
        /// </param>
        protected void CopyPwDatabaseFileToPath(string toPath, bool overwrite = true)
        {
            if (tempDatabaseBackupFile == null)
            {
                tempDatabaseBackupFile = GenerateTemporaryDatabaseFileCopy();
            }

            pluginLogger.Log(
                "Copy database to: " + toPath + " (from: " + tempDatabaseBackupFile + ")",
                LogStatusType.Info
            );
            FileSystem.CopyFile(
                new Uri(tempDatabaseBackupFile).LocalPath,
                new Uri(toPath).LocalPath,
                overwrite
            );
        }

        /// <summary>
        /// Generate a timestamp (as string) based on the format defined
        /// by the user.
        /// </summary>
        /// <returns>Time formatted by user preference.</returns>
        protected string GenerateUserConfiguredTimeString()
        {
            string dateTimeFormat = config.DateFormat;
            return DateTime.Now.ToString(dateTimeFormat);
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

        /// <summary>
        /// Create a temporary copy of the database file with a random
        /// file name and return the full path to the file.
        /// <br />The file path is also added to the list of the temporary
        /// files in this class.
        /// </summary>
        /// <returns>Full path to the temporary database file copy.</returns>
        private string GenerateTemporaryDatabaseFileCopy()
        {
            string tempFilePath = FILE_PREFIX + Path.GetTempPath() + 
                Path.GetRandomFileName() + dbFileExtension;
            SavePwDatabaseToPath(tempFilePath);
            temporaryFiles.Add(tempFilePath);
            return tempFilePath;
        }
    }
}
