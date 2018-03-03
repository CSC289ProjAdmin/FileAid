CREATE TABLE [dbo].[Reports]
(
	ReportID INT NOT NULL PRIMARY KEY Identity,
	sReportName varchar(100) not null,
	sReportDescription varchar(100) not null,
	dReportCreated datetime not null,
	dReportUpdated datetime not null,
	dReportDeleted datetime
)
