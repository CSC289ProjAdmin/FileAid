CREATE TABLE [dbo].[Configurations]
(
	ConfigID INT NOT NULL PRIMARY KEY Identity,
	iUpdateTimer int not null default 15,
	bShowInactive bit not null default 0,
	bUpdateMode bit not null default 0,
	sMasterPath varchar(max),
	dConfigCreated datetime not null,
	dConfigUpdated datetime not null,
	dConfigDeleted datetime
)
