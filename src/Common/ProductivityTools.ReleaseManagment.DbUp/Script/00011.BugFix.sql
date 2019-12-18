INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.4.2','2019.04.03','2019.04.09',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.4.3','2019.04.10','2019.04.16',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.4.4','2019.04.17','2019.04.23',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.4.5','2019.04.24','2019.05.07',[common].[GetDictValueId]('ScheduleType','BugFix'))

INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.5.1','2019.05.15','2019.05.21',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.5.2','2019.05.22','2019.05.28',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.5.3','2019.05.29','2019.06.04',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.5.4','2019.06.05','2019.06.11',[common].[GetDictValueId]('ScheduleType','BugFix'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.5.5','2019.06.12','2019.06.18',[common].[GetDictValueId]('ScheduleType','BugFix'))


INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.5','2019.03.07','2019.05.16',[common].[GetDictValueId]('ScheduleType','Release'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('10.6','2019.04.25','2019.06.27',[common].[GetDictValueId]('ScheduleType','Release'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('28','2019.06.27','2019.07.10',[common].[GetDictValueId]('ScheduleType','Release'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('29','2019.07.11','2019.07.24',[common].[GetDictValueId]('ScheduleType','Release'))
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId) VALUES ('30','2019.07.25','2019.08.07',[common].[GetDictValueId]('ScheduleType','Release'))

DECLARE @ScheduleId INT
SELECT top 1 @ScheduleId=ScheduleId FROM [general].Schedule where [Name]='10.5'

INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId,ParentScheduleId) VALUES ('Development','2019.03.07','2019.05.24',[common].[GetDictValueId]('ScheduleType','Release'),@ScheduleId)
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId,ParentScheduleId) VALUES ('Freeze - Release Candidate','2019.04.25','2019.06.27',[common].[GetDictValueId]('ScheduleType','Release'),@ScheduleId)
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId,ParentScheduleId) VALUES ('Freeze - Release Gated','2019.04.25','2019.06.27',[common].[GetDictValueId]('ScheduleType','Release'),@ScheduleId)
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId,ParentScheduleId) VALUES ('Freeze - Code Merge','2019.04.25','2019.06.27',[common].[GetDictValueId]('ScheduleType','Release'),@ScheduleId)
INSERT INTO [general].Schedule(Name,[Start],[End],ScheduleTypeDVId,ParentScheduleId) VALUES ('Freeze - Production deploy','2019.04.25','2019.06.27',[common].[GetDictValueId]('ScheduleType','Release'),@ScheduleId)


