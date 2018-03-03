CREATE TABLE [dbo].[Events]
(
	EventID INT NOT NULL PRIMARY KEY Identity,
	EventTypeID int not null References EventTypes(EventTypeID),
	dEvent datetime not null,
	sEventDescription varchar(100),
	sInitial varchar(100),
	sNew varchar(100),
	FileID int References TrackedFiles(FileID),
	LinkID int References FileLinks(LinkID),
	ReportID int References Reports(ReportID),
	ReminderID int References Reminders(ReminderID),
	BatchID int References Batches(BatchID),
	UserID int References Users(UserID),
	LoginID int References Logins(LoginID),
	PermID int References Permissions(PermID),
	ConfigID int References Configurations(ConfigID),
	dEventCreated datetime not null,
	dEventUpdated datetime not null,
	dEventDeleted datetime
)
