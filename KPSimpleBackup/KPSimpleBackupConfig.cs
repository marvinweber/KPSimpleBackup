using System;
using System.Collections.Generic;
using System.Linq;
using KeePass.App.Configuration;

namespace KPSimpleBackup
{
    public class KPSimpleBackupConfig
    {
        private AceCustomConfig customConfig;

        // default config values
        private static readonly long DEFAULT_FILE_AMOUNT_TO_KEEP = 15;
        private static readonly bool DEFAULT_USE_DATABASE_NAMES_FOR_BACKUP_FILES = false;
        private static readonly bool DEFAULT_USE_RECYCLE_BIN_DELETED_BACKUPS = true;
        private static readonly bool DEFAULT_AUTO_BACKUP_DATABASE = true;
        private static readonly string DEFAULT_DATE_FORMAT = "yyyy.MM.dd_H.mm.ss";
        private static readonly String EMPTY_STRING = "";
        private static readonly char PATH_SEPERATOR = ';';

        public KPSimpleBackupConfig(AceCustomConfig customConfig)
        {
            this.customConfig = customConfig;
        }

        public bool BackupConfigured
        {
            get
            {
                List<String> paths = this.BackupPath;
                return !(paths.Count == 0 || paths[0] == EMPTY_STRING);
            }
        }

        public List<String> BackupPath
        {
            get
            {
                String paths = this.customConfig.GetString("KPSimpleBackupConfig_backupPath", EMPTY_STRING);
                return paths.Split(PATH_SEPERATOR).ToList();
            }

            set
            {
                String paths = String.Join(Char.ToString(PATH_SEPERATOR), value.ToArray());
                this.customConfig.SetString("KPSimpleBackupConfig_backupPath", paths);
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

        public bool AutoDatabaseBackup
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_autoDatabaseBackup", DEFAULT_AUTO_BACKUP_DATABASE);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_autoDatabaseBackup", value);
            }
        }

        public string DateFormat
        {
            get
            {
                return this.customConfig.GetString("KPSimpleBackupConfig_dateFormat", DEFAULT_DATE_FORMAT);
            }

            set
            {
                this.customConfig.SetString("KPSimpleBackupConfig_dateFormat", value);
            }
        }
    }
}
