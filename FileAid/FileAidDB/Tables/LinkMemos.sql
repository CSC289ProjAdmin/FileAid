CREATE TABLE [dbo].[LinkMemos]
(
	LinkMemoID INT NOT NULL PRIMARY KEY Identity,
	sLinkMemo varchar(100),
	dMemoCreated datetime not null,
	dMemoUpdated datetime not null,
	dMemoDeleted datetime
)
