using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Linq;

namespace KPSimpleBackup
{
    public static class CleanupManager
    {
        /// <summary>
        /// Configuration of KPSimpleBackup
        /// </summary>
        public static KPSimpleBackupConfig config;

        /// <summary>
        /// Run a file cleanup, i.e. remove old files and only keep a
        /// given amount of (latest) files.
        /// </summary>
        /// <param name="path">Path to the directory to delete files within.</param>
        /// <param name="searchPattern">Pattern that files (that should be cleaned up) must fulfill.</param>
        /// <param name="originalDatabasePath">Path to original database. This path will never be removed.</param>
        /// <param name="amountToKeep">
        /// Amount of latest files to keep for given path and searchPattern. If this value is omitted or a
        /// negative value is specified, the default "keepAmount" from the user configuration is taken.
        /// </param>
        public static void Cleanup(
            string path, 
            string searchPattern,
            string originalDatabasePath,
            int amountToKeep = -1
        ) {
            string[] fileList = Directory.GetFiles(path, searchPattern).OrderByDescending(f => new FileInfo(f).CreationTime).ToArray();

            amountToKeep = amountToKeep < 0 ? (int) config.FileAmountToKeep : amountToKeep;
            RecycleOption recycleOption = config.UseRecycleBinDeletedBackups
                ? RecycleOption.SendToRecycleBin
                : RecycleOption.DeletePermanently;

            // if more backup files available than required delete the obsolete files
            if (fileList.Count() > amountToKeep)
            {
                for (int i = amountToKeep; i < fileList.Count(); i++)
                {
                    // never delete original file -> always skip it (in case it made it into the filelist)
                    if (fileList[i].Equals(originalDatabasePath))
                    {
                        continue;
                    }

                    FileSystem.DeleteFile(fileList[i], UIOption.OnlyErrorDialogs, recycleOption);
                }
            }
        }

    }
}
