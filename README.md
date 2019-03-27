# KeePass Simple Backup
This is a really simple KeePass Plugin that will save a backup of your Password-Database to a backup location and keep a specific amount of the newest backups (that you can define) every time you save your database or trigger the backup manually.

---

**Note: I don't accept responsibility for any data loss!**  
(However, the originial Database File should not be touched by this plugin. To prevent data loss don't disable the usage of the recycle bin!)

## Installation
Extract the zip-Archive you downloaded from the Release-Page and put either the `KPSimpleBackup.dll` or the `KPSimpleBackup.plgx` file in the `Plugins` folder of your KeePass instllation (portable version should work as well).  
You also can copy both files to the folder, KeePass will then decide for you which one it'll use ;)  
From the [KeePass Website](https://keepass.info/help/v2_dev/plg_index.html):  
> Dual package. You can ship a plugin both as a DLL and as a PLGX in one package (e.g. 'SecretImporter.dll' and 'SecretImporter.plgx' within one folder). KeePass will load the most appropriate file (if KeePass has been signed with the official assembly signing key, it will load the DLL, otherwise the PLGX). If KeePass loads the DLL, the PLGX is ignored, which especially means that only a weak compatibility check is performed (i.e. the strong compatibility detection ensured by the PLGX is lost). So, a dual package inherits the DLL disadvantages and is not the "best" solution either.

## Setup
To enable Backups simply go to `Tools -> KPSimpleBackup -> Settings` and add at least one folder where the backup files should be stored. Currently it's not possible to set the folder per database, so backups from all databases will be saved in the same folder (you can decide whether to use the file name or the database name in the advanced settings).

## Usage
*  When enabled in the advanced settings, the opened database will be backed up every time you save it
*  Backups can be triggered manually via the `Tools -> KPSimpleBackup -> Backup Database now!` menu entry
*  You can add multiple backup locations in the settings
*  After every backup a cleanup is performed -> only the x newest files will be kept, you can define how many (x) in the settings
*  In the advanced settings you can decide whether to use the recycle bin or not (depending on that the cleanup will move the files to the trash or delete them permanently)
*  You can choose the date format for the backup-files in the advanced settings. Only normal letters, digits and those chars: `:._+-;` are allowed, for details how to use the date format see [this Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings) as well.

## Windows Network Shares
Backups to a Samba-Server, etc. are also possible, just mount the Network-Share/ Server as a _Drive_. Then it's selectable from the Folder-Browser when you add a new backup-location.  
See also: https://support.microsoft.com/en-us/help/4026635/windows-map-a-network-drive