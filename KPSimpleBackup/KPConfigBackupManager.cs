using KeePassLib;
using KeePassLib.Utility;
using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace KPSimpleBackup
{
    public class KPConfigBackupManager : BackupManager
    {
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
                string configPath = GetConfigPath();
                string configFileName = Path.GetFileName(configPath);
                string backupConfigPath = FILE_PREFIX + basePath + configFileName + ".backup";
                backupConfigPath = new Uri(backupConfigPath).LocalPath;

                pluginLogger.Log("Copy " + configPath + " to " + backupConfigPath, KeePassLib.Interfaces.LogStatusType.Info);
                FileSystem.CopyFile(configPath, backupConfigPath, true);
            }
            catch (Exception e)
            {
                pluginLogger.Log("Could not backup KeePass configuration file!", KeePassLib.Interfaces.LogStatusType.Error);
                pluginLogger.Log(e.ToString(), KeePassLib.Interfaces.LogStatusType.AdditionalInfo);
            }
        }

        protected override void Cleanup()
        {
            //
        }

        private string GetConfigPath()
        {
            string strBaseDirName = PwDefs.ShortProductName;
            string appDataDir = KeePass.App.Configuration.AppConfigSerializer.AppDataDirectory;
            return UrlUtil.EnsureTerminatingSeparator(appDataDir, false) + strBaseDirName + ".config.xml";
            //System.Uri uri = new System.Uri(configUrl);
            //return uri.AbsoluteUri;
        }
    }
}
