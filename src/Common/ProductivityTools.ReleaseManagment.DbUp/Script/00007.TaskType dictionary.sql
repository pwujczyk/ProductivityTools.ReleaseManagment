
EXEC	[common].[AddDictionary]
		@DictionaryName = N'TaskType',
		@dictValueKey = N'Bug',
		@DictValuePL = N'Bug',
		@DictValueEN = N'Bug',
		@Order = 1


EXEC	[common].[AddDictionary]
		@DictionaryName = N'ScheduleType',
		@dictValueKey = N'Sprint',
		@DictValuePL = N'Sprint',
		@DictValueEN = N'Sprint',
		@Order = 0

		
EXEC	[common].[AddDictionary]
		@DictionaryName = N'ScheduleType',
		@dictValueKey = N'BugFix',
		@DictValuePL = N'BugFix',
		@DictValueEN = N'Bugfix',
		@Order = 0

EXEC	[common].[AddDictionary]
		@DictionaryName = N'ScheduleType',
		@dictValueKey = N'Release',
		@DictValuePL = N'Release',
		@DictValueEN = N'Release',
		@Order = 0
 
 