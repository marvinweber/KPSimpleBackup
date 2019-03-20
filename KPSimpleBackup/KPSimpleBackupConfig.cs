using System;
using KeePass.App.Configuration;

namespace KPSimpleBackup
{
    public class KPSimpleBackupConfig
    {
        private AceCustomConfig customConfig;

        // default config values
        private static readonly String DEFAULT_BACKUP_PATH = "";
        private static readonly long DEFAULT_FILE_AMOUNT_TO_KEEP = 15;
        private static readonly bool DEFAULT_USE_DATABASE_NAMES_FOR_BACKUP_FILES = false;
        private static readonly bool DEFAULT_USE_RECYCLE_BIN_DELETED_BACKUPS = true;

        public KPSimpleBackupConfig(AceCustomConfig customConfig)
        {
            this.customConfig = customConfig;
        }

        public bool BackupConfigured
        {
            get
            {
                return this.BackupPath != DEFAULT_BACKUP_PATH;
            }
        }

        public String BackupPath
        {
            get
            {
                return this.customConfig.GetString("KPSimpleBackupConfig_backupPath", DEFAULT_BACKUP_PATH);
            }

            set
            {
                this.customConfig.SetString("KPSimpleBackupConfig_backupPath", value);
            }
        }

        public long FileAmountToKeep
        {
            get
            {
                return this.customConfig.GetLong("KPSimpleBackupConfig_fileAmountToKeep", DEFAULT_FILE_AMOUNT_TO_KEEP);
            }

            set
            {
                this.customConfig.SetLong("KPSimpleBackupConfig_fileAmountToKeep", value);
            }
        }

        public bool UseDatabaseNameForBackupFiles
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_useDatabaseNameForBackupFiles", DEFAULT_USE_DATABASE_NAMES_FOR_BACKUP_FILES);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_useDatabaseNameForBackupFiles", value);
            }
        }

        public bool UseRecycleBinDeletedBackups
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_useRecycleBinDeletedBackups", DEFAULT_USE_RECYCLE_BIN_DELETED_BACKUPS);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_useRecycleBinDeletedBackups", value);
            }
        }
    }
}
