CREATE TABLE [dbo].[Logins]
(
	LoginID INT NOT NULL PRIMARY KEY Identity,
	UserID int not null References Users(UserID),
	dLogin datetime not null,
	dLoginCreated datetime not null,
	dLoginUpdated datetime not null,
	dLoginDeleted datetime
)
