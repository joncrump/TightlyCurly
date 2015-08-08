CREATE TABLE [dbo].[IngredientCategories]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IngredientCategoryId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
