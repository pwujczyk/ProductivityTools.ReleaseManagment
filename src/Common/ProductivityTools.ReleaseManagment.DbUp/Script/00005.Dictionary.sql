CREATE TABLE common.Dictionary
(
	DictionaryId INT NOT NULL,
	Name VARCHAR(30) NOT NULL,
	CreatedDate DATETIME NOT NULL CONSTRAINT DictoinaryDefaultCreateDate DEFAULT GETDATE(),
	
	CONSTRAINT PK_Dictionary PRIMARY KEY (DictionaryId)
)

CREATE TABLE common.DictValue
(
	DictValueId INT NOT NULL,
	DictionaryId INT NOT NULL,
	[Key] VARCHAR(30) NOT NULL,
	[ValuePL] VARCHAR(30) NOT NULL,
	[ValueEN] VARCHAR(30) NOT NULL,
	[Order] INT NOT NULL,
	CreatedDate DATETIME NOT NULL CONSTRAINT DictValueDefaultCreateDate DEFAULT GETDATE(),

	CONSTRAINT PK_DictValue PRIMARY KEY (DictValueId),
	CONSTRAINT FK_DictValue_Dictionary FOREIGN KEY (DictionaryId) REFERENCES common.Dictionary(DictionaryId)
) 