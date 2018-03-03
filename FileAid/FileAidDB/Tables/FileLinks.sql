CREATE TABLE [dbo].[FileLinks]
(
	LinkID INT NOT NULL PRIMARY KEY Identity,
	FileID int not null References TrackedFiles(FileID),
	LinkMemoID int not null References LinkMemos(LinkMemoID),
	dLinkCreated datetime not null,
	dLinkUpdated datetime not null,
	dLinkDeleted datetime
)
