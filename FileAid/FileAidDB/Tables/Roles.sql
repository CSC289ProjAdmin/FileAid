CREATE TABLE [dbo].[Roles]
(
	RoleID INT NOT NULL PRIMARY KEY Identity,
	sRoleName varchar(100) not null,
	PermID int not null References Permissions(PermID),
	dRoleCreated datetime not null,
	dRoleUpdated datetime not null,
	dRoleDeleted datetime
)
