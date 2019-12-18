CREATE TABLE [general].[Schedule]
(
	ScheduleId INT IDENTITY(1,1),
	Name VARCHAR(100) NOT NULL,
	[Start] DATETIME NOT NULL,
	[End] DATETIME NOT NULL,
	ParentScheduleId INT NULL,
	ScheduleTypeDVId INT NOT NULL,

	CreatedDate DATETIME NOT NULL CONSTRAINT SprintDefaultCreateDate DEFAULT GETDATE(),
	
	CONSTRAINT PK_Schedule PRIMARY KEY (ScheduleId),
)