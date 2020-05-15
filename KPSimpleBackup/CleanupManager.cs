using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Linq;

namespace KPSimpleBackup
{
    public static class CleanupManager
    {

        public static void Cleanup(
            string path, 
            string searchPattern,
            string originalDatabasePath,
            int amountToKeep,
            RecycleOption recycleOption
        ) {
            string[] fileList = Directory.GetFiles(path, searchPattern).OrderByDescending(f => new FileInfo(f).CreationTime).ToArray();

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
