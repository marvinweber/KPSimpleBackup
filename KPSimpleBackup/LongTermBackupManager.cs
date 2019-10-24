using KeePassLib;
using KeePassLib.Serialization;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.IO;
using System.Linq;

namespace KPSimpleBackup
{
    public class LongTermBackupManager
    {
        private const int STORAGE_TIME_WEEKLY = 4;
        private const int STORAGE_TIME_MONTHLY = 12;
        private const int STORAGE_TIME_YEARLY = 1000;

        private const string LTB_FOLDER_SUFFIX = "_long-term-backups";
        private const string LTB_FOLDER_WEEKLY = "weekly";
        private const string LTB_FOLDER_MONTHLY = "monthly";
        private const string LTB_FOLDER_YEARLY = "yearly";

        private const string FILE_PREFIX = "file:///";

        private string basePath;
        private string dbFileName;
        private string dbFileExtension;
        private PwDatabase database;

        private KPSimpleBackupConfig config;

        private string basePathWeekly;
        private string basePathMonthly;
        private string basePathYearly;

        public LongTermBackupManager(string basePath, string dbFileName, string dbFileExtension, PwDatabase database, KPSimpleBackupConfig config)
        {
            this.basePath = basePath;
            this.dbFileName = dbFileName;
            this.dbFileExtension = dbFileExtension;
            this.database = database;

            this.config = config;

            // assign folder paths
            this.basePathWeekly = basePath + dbFileName + LTB_FOLDER_SUFFIX + "/" + LTB_FOLDER_WEEKLY + "/";
            this.basePathMonthly = basePath + dbFileName + LTB_FOLDER_SUFFIX + "/" + LTB_FOLDER_MONTHLY + "/";
            this.basePathYearly = basePath + dbFileName + LTB_FOLDER_SUFFIX + "/" + LTB_FOLDER_YEARLY + "/";
        }

        public void RunLtb()
        {
            this.EnsureLtbFolderStructure();
            this.CreateBackupFiles();
            this.CleanupLtbFolders();
        }

        private void EnsureLtbFolderStructure()
        {
            Directory.CreateDirectory(this.basePathWeekly);
            Directory.CreateDirectory(this.basePathMonthly);
            Directory.CreateDirectory(this.basePathYearly);
        }

        private void CreateBackupFiles()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            System.DateTime now = System.DateTime.Now;
            Calendar cal = dfi.Calendar;

            // get current date information
            string weekOfYear = cal.GetWeekOfYear(now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString("00");
            string monthOfYear = cal.GetMonth(now).ToString("00");
            int year = cal.GetYear(now);

            // create paths and connection infos
            string pathWeekly = FILE_PREFIX + this.basePathWeekly + this.dbFileName + "_" + year + "-" + weekOfYear + this.dbFileExtension;
            IOConnectionInfo connectionWeekly = IOConnectionInfo.FromPath(pathWeekly);
            string pathMonthly = FILE_PREFIX + this.basePathMonthly + this.dbFileName + "_" + year + "-" + monthOfYear + this.dbFileExtension;
            IOConnectionInfo connectionMonthly = IOConnectionInfo.FromPath(pathMonthly);
            string pathYearly = FILE_PREFIX + this.basePathYearly + this.dbFileName + "_" + year + this.dbFileExtension;
            IOConnectionInfo connectionYearly = IOConnectionInfo.FromPath(pathYearly);

            // add all backup paths to list
            System.Collections.ArrayList filesToBackup = new System.Collections.ArrayList();
            filesToBackup.Add(connectionWeekly);
            filesToBackup.Add(connectionMonthly);
            filesToBackup.Add(connectionYearly);

            // perform backup for all files
            foreach (IOConnectionInfo fileInfo in filesToBackup)
            {
                this.database.SaveAs(fileInfo, false, null);
            }
        }

        private void CleanupLtbFolders()
        {
            string searchPattern = this.dbFileName + "_*" + this.dbFileExtension;

            this.Cleanup(this.basePathWeekly, searchPattern, STORAGE_TIME_WEEKLY);
            this.Cleanup(this.basePathMonthly, searchPattern, STORAGE_TIME_MONTHLY);
            this.Cleanup(this.basePathYearly, searchPattern, STORAGE_TIME_YEARLY);
        }

        private void Cleanup(string path, string searchPattern, int filesToKeepAmount)
        {
            // read from settings whether to use recycle bin or delete files permanently
            var recycleOption = this.config.UseRecycleBinDeletedBackups ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;

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
