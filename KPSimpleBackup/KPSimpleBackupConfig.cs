using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeePass.App.Configuration;

namespace KPSimpleBackup
{
    public class KPSimpleBackupConfig
    {
        private AceCustomConfig customConfig;

        public KPSimpleBackupConfig(AceCustomConfig customConfig)
        {
            this.customConfig = customConfig;
        }

        public bool BackupConfigured
        {
            get
            {
                return this.customConfig.GetBool("KPSimpleBackupConfig_backupConfigured", false);
            }

            set
            {
                this.customConfig.SetBool("KPSimpleBackupConfig_backupConfigured", value);
            }
        }

        public String BackupPath
        {
            get
            {
                return this.customConfig.GetString("KPSimpleBackupConfig_backupPath");
            }

            set
            {
                this.customConfig.SetString("KPSimpleBackupConfig_backupPath", value);
            }
        }

        public String BackupName
        {
            get
            {
                return this.customConfig.GetString("KPSimpleBackupConfig_backupName", "");
            }

            set
            {
                this.customConfig.SetString("KPSimpleBackupConfig_backupName", value);
            }
        }
    }
}
