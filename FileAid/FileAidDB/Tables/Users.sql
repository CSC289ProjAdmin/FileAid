CREATE TABLE [dbo].[Users]
(
	UserID INT NOT NULL PRIMARY KEY Identity,
	sUserName varchar(100) not null,
	sPassword varchar(100) not null,
	sDefaultPassword varchar(100) not null,
	bNeedsPasswordReset bit not null default 1,
	RoleID int not null References Roles(RoleID),
	iFailures int not null default 0,
	dLockedOut datetime,
	dUserDisabled datetime,
	dUserCreated datetime not null,
	dUserUpdated datetime not null,
	dUserDeleted datetime
)
