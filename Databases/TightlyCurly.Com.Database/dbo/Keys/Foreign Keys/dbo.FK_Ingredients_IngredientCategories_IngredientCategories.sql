ALTER TABLE [dbo].[Ingredients_IngredientCategories]
	ADD CONSTRAINT [FK_Ingredients_IngredientCategories_IngredientCategories]
	FOREIGN KEY (IngredientCategoryId)
	REFERENCES [dbo].[IngredientCategories] (IngredientCategoryId)
