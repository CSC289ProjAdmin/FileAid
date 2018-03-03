CREATE TABLE [dbo].[Batches]
(
	BatchID INT NOT NULL PRIMARY KEY Identity,
	iAdded int not null default 0,
	iModified int not null default 0,
	iDisabled int not null default 0,
	dBatchStart datetime not null,
	dBatchEnd datetime not null,
	bPeriodic bit not null default 0,
	dBatchCreated datetime not null,
	dBatchUpdated datetime not null,
	dBatchDeleted datetime
)
