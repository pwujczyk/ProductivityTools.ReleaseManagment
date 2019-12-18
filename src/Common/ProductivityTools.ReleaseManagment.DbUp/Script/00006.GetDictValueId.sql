CREATE FUNCTION [common].[GetDictValueId](@dictionaryName VARCHAR(30),@dictValueKey VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @dictValueID INT;

	SELECT @dictValueID=DictValueId FROM [common].DictValue dv
	INNER JOIN [common].Dictionary d ON
	dv.DictionaryId=d.DictionaryId
	where d.Name=@dictionaryName and dv.[Key]=@dictValueKey

	RETURN @dictValueID
END