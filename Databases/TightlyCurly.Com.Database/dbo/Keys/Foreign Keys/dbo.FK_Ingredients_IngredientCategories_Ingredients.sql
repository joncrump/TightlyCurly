ALTER TABLE [dbo].[Ingredients_IngredientCategories]
	ADD CONSTRAINT [FK_Ingredients_IngredientCategories_Ingredients]
	FOREIGN KEY (IngredientId)
	REFERENCES [dbo].[Ingredients] (IngredientId)
