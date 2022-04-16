# Changelog


## Version 1.4.0 (April 2021)
Related issues can be found in the release
[GitHub milestone](https://github.com/marvinweber/KPSimpleBackup/milestone/2).

### Added
* Performance Improvements for Long-Term-Backups: Instead of exporting the 
  database for each LTB backup separatly, it is exported once and copied
  afterwards now.
* Backups on Close: They will now only be created, if the database has been
  modified
* Backups of the KeePass config files now also are created with timestamps and
  they are cleaned up, similar to normal backups of database files.

### Fixes
* Relative backup paths are now relative to the database file, not the KeePass
  application.

### Miscellaneous
* Improved descriptions in the settings.
* Improved logging.


## Version 1.3.0 (May 2020)
Related issues can be found in the release
[GitHub milestone](https://github.com/marvinweber/KPSimpleBackup/milestone/1).

### Added
* Possibility to add "relative" backup paths in the advanced settings.
* Possibility to backup the KeePass configuration (`KeePass.config.xml`).

### Changed/ Improvements
* KeePass application window is blocked and greyed out during active backup
  process.
* Perfom cleanup based on creation time of files, not based on file name.
* Existence of backup location is verified and, otherwise, directory is created
  if possible.
* Show a warning if the backup finishes with errors by default.

### Miscellaneous
* Code cleanup & improvements.


## Version 1.2.1 (October 2019)
**Fix**: Backups crashed/ weren't performed (due to problem with logger).


## Version 1.2.0 (October 2019)
### Added
* Custom file-endings for backup-files.
* Long-Term-Backups.
* New backup-trigger: When the database or the KeePass application is being
  closed.
* Basic logging functionality, session log can be viewed via dropdown-menu
  `KPSimpleBackup > Open session log`.

### Changed/ Improvements
* It's possible now to select any directory as backup-directory, e.g. selecting
  an smb-share without mouning it as a drive.
* File-amount to keep (of backup files) can be set up to 10_000.
* Backup-files have same file-ending as original database (default).
* Redesigned `Settings > Advanced` tab to be more clear.


## Version 1.1.1 (September 2019)
### Fixes
* The list-box with the backup paths in the settings is now bigger and has
  horizontal scrolling enabled.
* Original database file won't be overwritten when backups are stored in the
  same directory.


## Version 1.1.0 (March 2019)
### Added
* Auto-Backup of the Database when it's being saved can now be disabled in the
  advanced settings.
* Multiple Backup Folders can now be added.
* Custom format for date/ time for the backup files can now be set, see docs for
  details.
* `.plgx` file is now also provided.

### Changed
* _Installation_: `.dll` file or `.plgx` file


## Version 1.0.0 (March 2019)
### Added
* Cleanup: Only keep specified amount of backup files per database.
* Choose whether to use Database Name or File Name for Backup File Name.
* Choose whether to move old backups to trash or delete them permanently.

### Changed
* Settings Form design tweaks
