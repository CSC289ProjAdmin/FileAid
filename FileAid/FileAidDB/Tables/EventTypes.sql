CREATE TABLE [dbo].[EventTypes]
(
	EventTypeID INT NOT NULL PRIMARY KEY Identity,
	sTypeCategory varchar(100) not null,
	sTypeDescription varchar(100) not null,
	dTypeCreated datetime not null,
	dTypeUpdated datetime not null,
	dTypeDeleted datetime
)
