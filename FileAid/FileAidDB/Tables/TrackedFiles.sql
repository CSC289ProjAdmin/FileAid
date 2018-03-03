CREATE TABLE [dbo].[TrackedFiles]
(
	FileID INT NOT NULL PRIMARY KEY Identity,
	sFileName varchar(100) not null,
	sFileExt varchar(100) not null,
	sFilePath varchar(max) not null,
	iSizeInBytes int not null,
	dFileModified datetime not null,
	dFileCreated datetime not null,
	sFileMemo varchar(100),
	dTrackingDisabled datetime,
	ReminderID int not null References Reminders(ReminderID),
	dTrackCreated datetime not null,
	dTrackUpdated datetime not null,
	dTrackDeleted datetime
)
