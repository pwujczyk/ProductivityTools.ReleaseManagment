ALTER TABLE [general].[Schedule]
ADD CONSTRAINT FK_Schedule_Schedule FOREIGN KEY (ParentScheduleId) REFERENCES [general].Schedule(ScheduleId)