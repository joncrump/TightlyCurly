CREATE TABLE [dbo].[IngredientCategoryNames]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IngredientCategoryNameId] UNIQUEIDENTIFIER	NOT NULL, 
	[IngredientCategoryId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientCategoryName] NVARCHAR(255) NOT NULL,
	[LocaleId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
