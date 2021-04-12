using KeePassLib;
using KeePassLib.Utility;
using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace KPSimpleBackup
{
    public class KPConfigBackupManager : BackupManager
    {
        private const string USER_BACKUP_SUFFIX = "backup-user-config_";
        private const string APPLICATION_BACKUP_SUFFIX = "backup-application-config_";

        protected override string ManagerName { get { return "KeePassConfigBackup"; } }

        public KPConfigBackupManager(PwDatabase database) : base(database)
        {
            //
        }

        protected override void PreBackup()
        {
            try
            {
                Directory.CreateDirectory(basePath);
                // ensure configuration is saved before backing it up
                KeePass.App.Configuration.AppConfigSerializer.Save(KeePass.Program.Config);
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
            try
            {
                CopyConfig(GetUserConfigPath(), USER_BACKUP_SUFFIX);
                CopyConfig(GetApplicationConfigPath(), APPLICATION_BACKUP_SUFFIX);
            }
            catch (Exception e)
            {
                pluginLogger.Log("Could not backup KeePass configuration file!", KeePassLib.Interfaces.LogStatusType.Error);
                pluginLogger.Log(e.ToString(), KeePassLib.Interfaces.LogStatusType.AdditionalInfo);
            }
        }

        /// <summary>
        /// Remove old/outdated config backups.
        /// </summary>
        protected override void Cleanup()
        {
            base.Cleanup();

            string applicationConfigName = Path.GetFileName(GetApplicationConfigPath());
            string userConfigName = Path.GetFileName(GetUserConfigPath());

            string applicationDeletePattern = applicationConfigName + "." + APPLICATION_BACKUP_SUFFIX + "*";
            string userDeletePattern = userConfigName + "." + USER_BACKUP_SUFFIX + "*";

            string dbPath = database.IOConnectionInfo.Path;
            CleanupManager.Cleanup(basePath, applicationDeletePattern, dbPath);
            CleanupManager.Cleanup(basePath, userDeletePattern, dbPath);
        }

        /// <summary>
        /// Get User configuration path used by the main
        /// KeePass application to store the configuration file
        /// </summary>
        /// <returns>path to the user configuration file</returns>
        private string GetUserConfigPath()
        {
            string appDataDir = KeePass.App.Configuration.AppConfigSerializer.AppDataDirectory;
            return UrlUtil.EnsureTerminatingSeparator(appDataDir, false) + GetConfigFileName();
        }

        /// <summary>
        /// Get Application configuration path stored in
        /// the same directory as the main KeePass application.
        /// This config is used by the portable KP version.
        /// </summary>
        /// <returns>path to the application config file</returns>
        private string GetApplicationConfigPath()
        {
            string curDir = Environment.CurrentDirectory;
            return UrlUtil.EnsureTerminatingSeparator(curDir, false) + GetConfigFileName();
        }

        private string GetConfigFileName()
        {
            string strBaseDirName = PwDefs.ShortProductName;
            return strBaseDirName + ".config.xml";
        }

        /// <summary>
        /// Copy a configuration file to the backup directory
        /// if it is available.
        /// </summary>
        /// <param name="configPath">path of the config file</param>
        /// <param name="suffix">suffix to append to the backup-file-name</param>
        private void CopyConfig(string configPath, string suffix)
        {
            if (! FileSystem.FileExists(configPath))
            {
                pluginLogger.Log("Skipping path, no configuration found at: " + configPath, KeePassLib.Interfaces.LogStatusType.Info);
                return;
            }

            string time = GenerateUserConfiguredTimeString();
            string configFileName = Path.GetFileName(configPath);
            string backupConfigPath = FILE_PREFIX + basePath + configFileName + "." + suffix + time;
            backupConfigPath = new Uri(backupConfigPath).LocalPath;

            pluginLogger.Log("Copy " + configPath + " to " + backupConfigPath, KeePassLib.Interfaces.LogStatusType.Info);
            FileSystem.CopyFile(configPath, backupConfigPath, true);
        }
    }
}
