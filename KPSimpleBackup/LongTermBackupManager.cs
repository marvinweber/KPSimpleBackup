using KeePassLib;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

            Directory.CreateDirectory(basePathWeekly);
            Directory.CreateDirectory(basePathMonthly);
            Directory.CreateDirectory(basePathYearly);
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

            // perform backup for all files
            foreach (string fileInfo in backupPaths)
            {
                SavePwDatabaseToPath(fileInfo);
            }
        }

        protected override void Cleanup()
        {
            string searchPattern = dbFileName + "_*" + dbFileExtension;

            CleanupLTB(basePathWeekly, searchPattern, config.LtbWeeklyAmount);
            CleanupLTB(basePathMonthly, searchPattern, config.LtbMonthlyAmount);
            CleanupLTB(basePathYearly, searchPattern, config.LtbYearlyAmount);
        }

        private void CleanupLTB(string path, string searchPattern, int filesToKeepAmount)
        {
            // read from settings whether to use recycle bin or delete files permanently
            var recycleOption = BackupManager.config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;

            //searchPattern = fileNamePrefix + "_*.kdbx";
            string[] fileList = Directory.GetFiles(path, searchPattern).OrderBy(f => f).Reverse().ToArray();

            // if more backup files available than needed loop through the unnecessary ones and remove them
            if (fileList.Count() > filesToKeepAmount)
            {
                for (int i = filesToKeepAmount; i < fileList.Count(); i++)
                {
                    FileSystem.DeleteFile(fileList[i], UIOption.OnlyErrorDialogs, recycleOption);
                }
            }
        }
    }
}
