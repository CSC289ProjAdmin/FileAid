/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Insert Into Reports
    (sReportName, sReportDescription, dReportCreated, dReportUpdated)
Values
    ('Logins', 'Record of all logins to FileAid', GetDate(), GetDate())
;

INSERT INTO [dbo].[EventTypes]
           ([sTypeCategory]
           ,[sTypeDescription]
           ,[dTypeCreated]
           ,[dTypeUpdated]
           ,[dTypeDeleted])
     VALUES
           ('File Tracking'
           ,'File Added'
           ,getdate()
           ,getdate()
           ,null)
;

INSERT INTO [dbo].[Reminders]
           ([sReminderName]
           ,[dDue]
           ,[sReminderMemo]
           ,[dResolved]
           ,[dPushed]
           ,[dReminderCreated]
           ,[dReminderUpdated]
           ,[dReminderDeleted])
     VALUES
           ('First reminder'
           ,'2018-12-25'
           ,'Description for first reminder'
           ,null
           ,null
           ,getdate()
           ,getdate()
           ,null)
		   ,
           ('Second reminder'
           ,'2018-12-25'
           ,'Description for second reminder'
           ,null
           ,null
           ,getdate()
           ,getdate()
           ,null)
;


INSERT INTO [dbo].[LinkMemos]
           ([sLinkMemo]
           ,[dMemoCreated]
           ,[dMemoUpdated]
           ,[dMemoDeleted])
     VALUES
           ('First link'
           ,getdate()
           ,getdate()
           ,null)
;


INSERT INTO [dbo].[TrackedFiles]
           ([sFileName]
           ,[sFileExt]
           ,[sFilePath]
           ,[iSizeInBytes]
           ,[dFileModified]
           ,[dFileCreated]
           ,[sFileMemo]
           ,[dTrackingDisabled]
           ,[ReminderID]
           ,[dTrackCreated]
           ,[dTrackUpdated]
           ,[dTrackDeleted])
     VALUES
           ('First File'
           ,'DOCX'
           ,'C:\My Documents'
           ,1000000
           ,getdate()
           ,getdate()
           ,'Description of first file'
           ,null
           ,(select min(reminderID) from reminders where sReminderName like '%first%')
           ,getdate()
           ,getdate()
           ,null)
           ,
           ('Second File'
           ,'XLXS'
           ,'C:\Users\Desktop'
           ,50000
           ,getdate()
           ,getdate()
           ,'Description of second file'
           ,null
           ,(select min(reminderID) from reminders where sReminderName like '%second%')
           ,getdate()
           ,getdate()
           ,null)
           ,
           ('Third File'
           ,'DOCX'
           ,'C:\My Documents'
           ,1000000
           ,getdate()
           ,getdate()
           ,'Description of third file'
           ,null
           ,(select min(reminderID) from reminders where sReminderName like '%first%')
           ,getdate()
           ,getdate()
           ,null)
;


INSERT INTO [dbo].[Events]
           ([EventTypeID]
           ,[dEvent]
           ,[sEventDescription]
           ,[sInitial]
           ,[sNew]
           ,[FileID]
           ,[LinkID]
           ,[ReportID]
           ,[ReminderID]
           ,[BatchID]
           ,[UserID]
           ,[LoginID]
           ,[PermID]
           ,[ConfigID]
           ,[dEventCreated]
           ,[dEventUpdated]
           ,[dEventDeleted])
     VALUES
           ((select min(eventtypeid) from EventTypes where sTypeDescription like '%file added%')
           ,getdate()
           ,'First file added to system'
           ,null
           ,null
           ,(select min(fileid) from TrackedFiles where sfilename like '%First%')
           ,null
           ,null
           ,null
           ,null
           ,null
           ,null
           ,null
           ,null
           ,getdate()
           ,getdate()
           ,null)
;


INSERT INTO [dbo].[FileLinks]
           ([FileID]
           ,[LinkMemoID]
           ,[dLinkCreated]
           ,[dLinkUpdated]
           ,[dLinkDeleted])
     VALUES
           ((select min(fileid) from TrackedFiles where sFileName like '%First%')
           ,(select min(linkmemoID) from LinkMemos where sLinkMemo like '%First%')
           ,getdate()
           ,getdate()
           ,null)
;
