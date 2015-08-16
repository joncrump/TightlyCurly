CREATE TABLE [dbo].[Ingredients_IngredientCategories]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[IngredientId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientCategoryId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
