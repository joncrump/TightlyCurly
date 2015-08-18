ALTER TABLE [dbo].[IngredientRatings]
	ADD CONSTRAINT [FK_IngredientRatings_Ingredients]
	FOREIGN KEY (IngredientId)
	REFERENCES [dbo].[Ingredients] (IngredientId)
