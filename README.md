# KeePass Simple Backup
This is a really simple KeePass Plugin that will save a backup of your Password-Database to a backup location and keep a specific amount of the newest backups (that you can define) every time you save your database or trigger the backup manually.

---

**Note: I don't accept responsibility for any data loss!**  
(However, the originial Database File should not be touched by this plugin. To prevent data loss don't disable the usage of the recycle bin!)

## Installation
Simply put the `KPSimpleBackup.dll` file in the `Plugins` folder of your KeePass installation (portable version should work as well)

## Setup
To enable Backups simply go to `Tools -> KPSimpleBackup -> Settings` and select a folder for the backup files. Currently it's not possible to set the folder per database, so backups from all databases will be saved in the same folder (you can decide wether to use the file name oder the database name in the advanced settings).

## Usage
*  When enabled in the advanced settings, the opend database will be backed up when it's being saved
*  Backups can be triggered manually via the `Tools -> KPSimpleBackup -> Backup Database now!` menu
*  After every backup a cleanup is performed -> only the x newest files will be kept, you can define how many in the settings
*  In the advanced settings you can decide wether to use the recycle bin or not (depending on that the removed backups from the cleanup will be moved to the trash or deleted permanently)

## Planned features
This plugin is meant to be really simple, but probably i will add the following features (when i have the time :) )
*  KeePass plgx file (this will come for sure...)
*  Custom date-format
*  Multiple Backup folders