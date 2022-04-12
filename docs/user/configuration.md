# Configuration

## Initial Setup
To enable Backups simply go to `Tools -> KPSimpleBackup -> Settings` and add at least one folder where the backup files should be stored.

**Manual Backup**: After intial configuration of at least one backup directory, you can always trigger a manual backup via the context menu `Tools -> KPSimpleBackup -> Backup Database now!`. Automatic backups are enabled by default, too. See below for more information about configuring them!

## Settings
General Settings           |  Advanced Settings
:-------------------------:|:-------------------------:
![general-settings-screenshot](https://raw.githubusercontent.com/marvinweber/KPSimpleBackup/main/resources/screenshots/settings_general.png)  |  ![advanced-settings-screenshot](https://raw.githubusercontent.com/marvinweber/KPSimpleBackup/main/resources/screenshots/settings_advanced.png)

## General Settings

- (1) **Amount of backup-files** to keep per database (the latest files will be kept).  
- (2) **Add new backup location** (directory) to the list of backup locations.
- (3) List of all currently selected/added backup locations.  
- (4) **Remove the selected backup location** (select a location/directory from the list and remove it).  
- (5) **Date/ time format** to use for the backup files.  
Only the following characters are allowed: `:._+-;` (additionally to the "configuration"-characters)  
More information about the format in [this Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings).  
- (6) **Enable/Disable** backups of the KeePass configuration files

## Advanced Settings

- (7) You can either use the file-name of the KeePass-file (**Default and recommended!**) or the _name_ of your database for the backup-file-names.
- (8) Deleted backup files (by cleanup) will be moved to your recycle bin by default. If you wish to delete them permanentley instead, disable this option. (⚠️ Please test, whether cleanup is working properly, before you disable this feature!)
- (9) **Backup Database on Save**: If enabled, a new backup will be performed whenever you save your database (or KeePass does save the database automatically). If disabled, you still can perform backups manually via the "Tools" context menu, or via (12).
- (10) **Warnings**: If enabled, a popup will be shown if a backup fails for whatever reason. If disabled, you can still see whether backups were sucessfull or not in the info text at the left bottom corner of the KeePass window.
- (11) **Custom File Extension** for backup files: you can specify a custom file extension/ending that should always be used for backup files of the database (instead of the original file ending).
- (12) **Backup on close**: If enabled, backups will be triggered if the database is closed or locked or if KeePass is exited. A backup will only be performed, if the database has been modified after the last backup.
- (13) **Relative Backup Paths**: You can add a relative backup location (relative to the location of the database file!) here.

### (14) Long Term Backups
The Long Term Backup (LTB) Feature can be used to keep a longer history of your password database. It will save one backup file per week, per month and per year, keeping as many files as you define at (15).  
LTB's are triggered every time, when the "normal backup" is triggered as well and they will be stored in a subfolder (of your backup location(s)) named `<your-file-name>_long-term-backups`.

## Network Shares / Samba / etc
You can select network shares as your backup location, too. You can either type in the URL, e.g. `\\myshare\folder\backup` in the folder-selection-dialog in the path-bar at the top; or you mount your network share as a drive and select it as a usual local drive in the directory-selection.

## Relative Backup path
A relative backup path is relative to the location of the database file, that is currently backed up. You can use this, for instance, to create history backups in a subdirectory of where your database is stored. This may be useful, if you work with multiple KeePass files.  
Please test, if your backups are created in the correct directory!
