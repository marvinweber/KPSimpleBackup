using KeePassLib;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;
using System.IO;

namespace KPSimpleBackup
{
    public class LongTermBackupManager : BackupManager
    {
        protected override string ManagerName { get { return "LongTermBackup"; } }

        private const string LTB_FOLDER_SUFFIX = "_long-term-backups";
        private const string LTB_FOLDER_WEEKLY = "weekly";
        private const string LTB_FOLDER_MONTHLY = "monthly";
        private const string LTB_FOLDER_YEARLY = "yearly";

        private string basePathWeekly;
        private string basePathMonthly;
        private string basePathYearly;

        private string weekOfYear;
        private string monthOfYear;
        private int year;

        public LongTermBackupManager(PwDatabase database) : base(database)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            System.DateTime now = System.DateTime.Now;
            Calendar cal = dfi.Calendar;

            // get current date information
            weekOfYear = cal.GetWeekOfYear(now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString("00");
            monthOfYear = cal.GetMonth(now).ToString("00");
            year = cal.GetYear(now);
        }

        protected override void PreBackup()
        {
            basePathWeekly = basePath + dbFileName + LTB_FOLDER_SUFFIX + "/" + LTB_FOLDER_WEEKLY + "/";
            basePathMonthly = basePath + dbFileName + LTB_FOLDER_SUFFIX + "/" + LTB_FOLDER_MONTHLY + "/";
            basePathYearly = basePath + dbFileName + LTB_FOLDER_SUFFIX + "/" + LTB_FOLDER_YEARLY + "/";

            try
            {
                Directory.CreateDirectory(basePathWeekly);
                Directory.CreateDirectory(basePathMonthly);
                Directory.CreateDirectory(basePathYearly);
            }
            catch (Exception e)
            {
                pluginLogger.Log("Could not create backup directories!", KeePassLib.Interfaces.LogStatusType.Error);
                pluginLogger.Log("Exception: " + e.ToString(), KeePassLib.Interfaces.LogStatusType.AdditionalInfo);
                throw e;
            }
        }

        protected override void Backup()
        {
            // create paths for all files
            string pathWeekly = FILE_PREFIX + basePathWeekly + dbFileName + "_" + year + "-" + weekOfYear + dbFileExtension;
            string pathMonthly = FILE_PREFIX + basePathMonthly + dbFileName + "_" + year + "-" + monthOfYear + dbFileExtension;
            string pathYearly = FILE_PREFIX + basePathYearly + dbFileName + "_" + year + dbFileExtension;
            System.Collections.ArrayList backupPaths = new System.Collections.ArrayList {
                pathWeekly,
                pathMonthly,
                pathYearly
            };

            // perform backup for all files (i.e., LTB locations)
            foreach (string backupPath in backupPaths)
            {
                CopyPwDatabaseFileToPath(backupPath);
            }
        }

        protected override void Cleanup()
        {
            base.Cleanup();

            string searchPattern = dbFileName + "_*" + dbFileExtension;
            RecycleOption recycleOption = config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;

            CleanupManager.Cleanup(basePathWeekly, searchPattern, database.IOConnectionInfo.Path, config.LtbWeeklyAmount, recycleOption);
            CleanupManager.Cleanup(basePathMonthly, searchPattern, database.IOConnectionInfo.Path, config.LtbMonthlyAmount, recycleOption);
            CleanupManager.Cleanup(basePathYearly, searchPattern, database.IOConnectionInfo.Path, config.LtbYearlyAmount, recycleOption);
        }
    }
}
