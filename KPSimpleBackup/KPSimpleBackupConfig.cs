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
        private static readonly string DEFAULT_BACKUP_FILE_EXTENSION = ".kdbx";
        private static readonly bool DEFAULT_SHOW_BACKUP_FAILED_WARNING = true;
        private static readonly bool DEFAULT_LOG_TO_FILE = false;
        private static readonly long DEFAULT_FILE_AMOUNT_TO_KEEP = 15;
        private static readonly bool DEFAULT_USE_DATABASE_NAMES_FOR_BACKUP_FILES = false;
        private static readonly bool DEFAULT_USE_RECYCLE_BIN_DELETED_BACKUPS = true;
        private static readonly bool DEFAULT_AUTO_BACKUP_DATABASE = true;
        private static readonly bool DEFAULT_BACKUP_ON_DB_CLOSE = false;
        private static readonly bool DEFAULT_USE_LONG_TERM_BACKUP = false;
        private static readonly long DEFAULT_LTB_WEEKLY_AMOUNT = 4;
        private static readonly long DEFAULT_LTB_MONTHLY_AMOUNT = 12;
        private static readonly long DEFAULT_LTB_YEARLY_AMOUNT = 1000;
        private static readonly bool DEFAULT_BACKUP_KEEPASS_CONFIG = false;
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

        public bool ShowBackupFailedWarning
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_showBackupFailedWarning", DEFAULT_SHOW_BACKUP_FAILED_WARNING);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_showBackupFailedWarning", value);
            }
        }

        public bool LogToFile
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_logToFile", DEFAULT_LOG_TO_FILE);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_logToFile", value);
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

        public string BackupFileExtension
        {
            get
            {
                return this.customConfig.GetString("KPSimpleBackupConfig_backupFileExtension", DEFAULT_BACKUP_FILE_EXTENSION);
            }

            set
            {
                this.customConfig.SetString("KPSimpleBackupConfig_backupFileExtension", value);
            }
        }

        public bool UseCustomBackupFileExtension
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_useCustomBackupFileExtension", false);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_useCustomBackupFileExtension", value);
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

        public bool BackupOnDbClose
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_backupOnDbClose", DEFAULT_BACKUP_ON_DB_CLOSE);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_backupOnDbClose", value);
            }
        }

        public bool UseLongTermBackup
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_useLongTermBackup", DEFAULT_USE_LONG_TERM_BACKUP);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_useLongTermBackup", value);
            }
        }

        public int LtbWeeklyAmount
        {
            get
            {
                return (int) this.customConfig.GetLong("KPSimpleBackupConfig_ltbWeeklyAmount", DEFAULT_LTB_WEEKLY_AMOUNT);
            }

            set
            {
                this.customConfig.SetLong("KPSimpleBackupConfig_ltbWeeklyAmount", value);
            }
        }

        public int LtbMonthlyAmount
        {
            get
            {
                return (int)this.customConfig.GetLong("KPSimpleBackupConfig_ltbMonthlyAmount", DEFAULT_LTB_MONTHLY_AMOUNT);
            }

            set
            {
                this.customConfig.SetLong("KPSimpleBackupConfig_ltbMonthlyAmount", value);
            }
        }

        public int LtbYearlyAmount
        {
            get
            {
                return (int)this.customConfig.GetLong("KPSimpleBackupConfig_ltbYearlyAmount", DEFAULT_LTB_YEARLY_AMOUNT);
            }

            set
            {
                this.customConfig.SetLong("KPSimpleBackupConfig_ltbYearlyAmount", value);
            }
        }

        public bool BackupKeePassConfig
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_backupKeePassConfig", DEFAULT_BACKUP_KEEPASS_CONFIG);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_backupKeePassConfig", value);
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
