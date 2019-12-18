
CREATE TABLE [AngryNerds].[Task]
(
	TaskId INT IDENTITY(1,1),
	Title VARCHAR(200) NOT NULL,
	Description VARCHAR(1000),
		
	SprintId INT NOT NULL,
	TaskTypeDictId INT NOT NULL,

	CONSTRAINT PK_Task PRIMARY KEY (TaskId),
	CONSTRAINT FK_Task_Sprint FOREIGN KEY (SprintId) REFERENCES [general].Sprint(SprintId)
)