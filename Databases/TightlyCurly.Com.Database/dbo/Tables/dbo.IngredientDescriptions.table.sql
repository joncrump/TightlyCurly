CREATE TABLE [dbo].[IngredientDescriptions]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IngredientDescriptionId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientDescription]	NVARCHAR(255) NOT NULL,
	[LocaleId] INT NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
