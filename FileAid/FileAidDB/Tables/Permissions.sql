CREATE TABLE [dbo].[Permissions]
(
	PermID INT NOT NULL PRIMARY KEY Identity,
	bChangeAdminPass bit not null default 0,
	bChangeUserPass bit not null default 0,
	bChangeGuestPass bit not null default 0,
	bEnableUser bit not null default 0,
	bEnableGuest bit not null default 0,
	bResetUserPass bit not null default 0,
	bResetGuessPass bit not null default 0,
	bUnlockUser bit not null default 0,
	bUnlockGuest bit not null default 0,
	bRestrictGuest bit not null default 0,
	bResetDb bit not null default 0,
	bBackupDb bit not null default 0,
	bRestoreDb bit not null default 0,
	bBatchScan bit not null default 0,
	bProgramSetup bit not null default 0,
	bLoginMgmt bit not null default 0,
	bDbMgmt bit not null default 0,
	dPermCreated datetime not null,
	dPermUpdated datetime not null,
	dPermDeleted datetime
)
