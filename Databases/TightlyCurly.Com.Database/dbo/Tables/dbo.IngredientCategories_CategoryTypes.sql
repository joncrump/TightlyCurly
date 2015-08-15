CREATE TABLE [dbo].[IngredientCategories_CategoryTypes]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IngredientCategoriesCategoryTypesId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientCategoryId] UNIQUEIDENTIFIER NOT NULL,
	[CategoryTypeId] UNIQUEIDENTIFIER NOT NULL
)
