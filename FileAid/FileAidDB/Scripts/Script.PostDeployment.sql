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
Insert Into Configurations
    (iUpdateTimer, bShowInactive, bUpdateMode, dConfigCreated, dConfigUpdated)
Values
    (15, 0, 0, GetDate(), GetDate())
;

Insert Into Reports
    (sReportName, sReportDescription, dReportCreated, dReportUpdated)
Values
    ('Logins', 'Record of all logins to FileAid', GetDate(), GetDate())
;

SET IDENTITY_INSERT [dbo].[EventTypes] ON
INSERT INTO [dbo].[EventTypes]
		   ([EventTypeID]
		   ,[sTypeCategory]
           ,[sTypeDescription]
           ,[dTypeCreated]
           ,[dTypeUpdated]
           ,[dTypeDeleted])
     VALUES
(1,'File Tracking','File Added', getdate(), getdate(),null),
(2,	'File Tracking','File Info Modified', getdate(), getdate(),null),
(3,	'File Tracking','Tracking Stopped', getdate(), getdate(),null),
(4,	'File Tracking','Tracking Restarted', getdate(), getdate(),null),
(5,	'File Tracking','Description Updated', getdate(), getdate(),null),
(6,	'File Tracking','Description Removed', getdate(), getdate(),null),
(7,	'File Tracking','Reminder Set', getdate(), getdate(),null),

(8,'File Linking',	'Group Created', getdate(), getdate(),null),
(9,'File Linking','Joined Group', getdate(), getdate(),null),
(10,	'File Linking','Left Group', getdate(), getdate(),null),
(11,	'File Linking','Memo Updated', getdate(), getdate(),null),
(12,	'File Linking','Memo Removed', getdate(), getdate(),null),

(13,'Ticklers',	'Added', getdate(), getdate(),null),
(14,	'Ticklers','Resolved', getdate(), getdate(),null),
(15,	'Ticklers','Pushed', getdate(), getdate(),null),
(16,	'Ticklers','Memo Updated', getdate(), getdate(),null),
(17,	'Ticklers','Memo Removed', getdate(), getdate(),null),

(18,'Logins',	'Successful Login', getdate(), getdate(),null),
(19,	'Logins','Failed Login', getdate(), getdate(),null),

(20,'User Management',	'Locked Out', getdate(), getdate(),null),
(21,	'User Management','Unlocked', getdate(), getdate(),null),
(22,	'User Management','Disabled', getdate(), getdate(),null),
(23,	'User Management','Enabled', getdate(), getdate(),null),
(24,	'User Management','Password Changed', getdate(), getdate(),null),
(25,	'User Management','Password Reset', getdate(), getdate(),null),
(26,	'User Management','Permissions Changed', getdate(), getdate(),null),

(27,'Database Management',	'Backed Up', getdate(), getdate(),null),
(28,	'Database Management','Restored', getdate(), getdate(),null),
(29,	'Database Management','Reset', getdate(), getdate(),null),

(30,'Batch Update',	'Started - Manual', getdate(), getdate(),null),
(31,'Batch Update',	'Started - Auto', getdate(), getdate(),null),
(32,'Batch Update','Completed', getdate(), getdate(),null),

(33,'Reports',	'Report Run', getdate(), getdate(),null)
;
SET IDENTITY_INSERT [dbo].[EventTypes] OFF

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

INSERT INTO [dbo].[Permissions]
           ([bChangeAdminPass]
           ,[bChangeUserPass]
           ,[bChangeGuestPass]
           ,[bEnableUser]
           ,[bEnableGuest]
           ,[bResetUserPass]
           ,[bResetGuessPass]
           ,[bUnlockUser]
           ,[bUnlockGuest]
           ,[bRestrictGuest]
           ,[bResetDb]
           ,[bBackupDb]
           ,[bRestoreDb]
           ,[bBatchScan]
           ,[bProgramSetup]
           ,[bLoginMgmt]
           ,[bDbMgmt]
           ,[dPermCreated]
           ,[dPermUpdated]
           ,[dPermDeleted])
     VALUES
           (1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,getdate()
           ,getdate()
           ,null) -- Admin end
		   ,
           (0
           ,1
           ,1
           ,0
           ,1
           ,0
           ,1
           ,0
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,1
           ,getdate()
           ,getdate()
           ,null) -- User end
		   ,
           (0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,0
           ,getdate()
           ,getdate()
           ,null) -- Guest end
;

INSERT INTO [dbo].[Roles]
           ([sRoleName]
           ,[PermID]
           ,[dRoleCreated]
           ,[dRoleUpdated]
           ,[dRoleDeleted])
     VALUES
           ('Admin'
           ,(select min(permid) from permissions where bChangeAdminPass = 1 and dPermDeleted is null)
           ,getdate()
           ,getdate()
           ,null)
		   ,
           ('User'
           ,(select min(permid) from permissions where bChangeAdminPass = 0 and bChangeUserPass = 1 and dPermDeleted is null)
           ,getdate()
           ,getdate()
           ,null)
		   ,
           ('Guest'
           ,(select min(permid) from permissions where bChangeAdminPass = 0 and bChangeUserPass = 0 and dPermDeleted is null)
           ,getdate()
           ,getdate()
           ,null)
;

INSERT INTO [dbo].[Users]
           ([sUserName]
           ,[sPassword]
		   ,[sDefaultPassword]
           ,[RoleID]
           ,[iFailures]
           ,[dLockedOut]
           ,[dUserDisabled]
           ,[dUserCreated]
           ,[dUserUpdated]
           ,[dUserDeleted])
     VALUES
           ('Admin'
           ,'Admin'
		   ,'Admin'
           ,(select min(roleID) from roles where sRoleName = 'Admin' and dRoleDeleted is null)
           ,0
           ,null
           ,null
           ,getdate()
           ,getdate()
           ,null)
		   ,
           ('User'
           ,'' -- no initial password
		   ,'' -- empty default password
           ,(select min(roleID) from roles where sRoleName = 'User' and dRoleDeleted is null)
           ,0
           ,null
           ,null
           ,getdate()
           ,getdate()
           ,null)
		   ,
           ('Guest'
           ,'' -- no initial password
		   ,'' -- empty default password
           ,(select min(roleID) from roles where sRoleName = 'Guest' and dRoleDeleted is null)
           ,0
           ,null
           ,null
           ,getdate()
           ,getdate()
           ,null)
;
