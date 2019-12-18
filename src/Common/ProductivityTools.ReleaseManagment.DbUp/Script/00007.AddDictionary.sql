CREATE PROCEDURE [common].[AddDictionary]
	@DictionaryName VARCHAR(30),
	@dictValueKey VARCHAR(30),
	@DictValuePL VARCHAR(30),
	@DictValueEN VARCHAR(30),
	@Order INT
AS 
BEGIN

	DECLARE @dictionaryId INT, @dictValueId INT, @dictionaryMax INT, @dictValueMax INT
	
	SELECT @dictionaryId = DictionaryId FROM common.Dictionary WHERE Name=@DictionaryName
	IF (@dictionaryId IS NULL)
	BEGIN
		
		SELECT @dictionaryMax=ISNULL(MAX(DictionaryId),0) FROM common.Dictionary
		SET @dictionaryMax=@dictionaryMax+1;


		INSERT INTO [common].Dictionary(DictionaryId, Name) VALUES (@dictionaryMax,@DictionaryName)
		SELECT @dictionaryId=@dictionaryMax
	END
	
		
	SELECT @dictValueId = DictValueId FROM common.DictValue WHERE DictionaryId=@dictionaryId AND [Key]=@dictValueKey
	PRINT 'DICTVALUE' 
	PRINT @dictValueId


	IF (@dictValueId IS NULL)
	BEGIN
	
		SELECT @dictValueMax=ISNULL(MAX(DictValueId),0) FROM common.DictValue
		PRINT @dictValueMax
		SET @dictValueMax=@dictValueMax+1;
		INSERT INTO [common].DictValue (DictValueId, DictionaryId,[Key],ValuePL,ValueEN,[Order]) VALUES (@dictValueMax, @dictionaryId,@dictValueKey,@DictValuePL,@DictValueEN,@Order)

	END 
	ELSE
	BEGIN
		UPDATE [common].DictValue SET ValuePL=@DictValuePL,ValueEN=@DictValueEN,[Order]=@Order WHERE DictionaryId=@dictionaryId AND [Key]=@dictValueKey
	END
	
END

GO


