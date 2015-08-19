ALTER TABLE [dbo].[Ingredients_ContentArticles]
	ADD CONSTRAINT [FK_Ingredients_ContentArticles_Ingredients]
	FOREIGN KEY (IngredientId)
	REFERENCES [dbo].[Ingredients] (IngredientId)
