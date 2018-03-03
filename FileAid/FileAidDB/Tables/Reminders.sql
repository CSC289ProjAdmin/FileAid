CREATE TABLE [dbo].[Reminders]
(
	ReminderID INT NOT NULL PRIMARY KEY Identity,
	sReminderName varchar(100) not null,
	dDue datetime not null,
	sReminderMemo varchar(100),
	dResolved datetime,
	dPushed datetime,
	dReminderCreated datetime not null,
	dReminderUpdated datetime not null,
	dReminderDeleted datetime
)
