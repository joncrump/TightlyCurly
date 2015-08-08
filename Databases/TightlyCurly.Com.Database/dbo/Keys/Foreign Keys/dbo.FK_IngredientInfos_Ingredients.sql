ALTER TABLE [dbo].[IngredientInfos]
	ADD CONSTRAINT [FK_IngredientInfos_Ingredients]
	FOREIGN KEY (IngredientId)
	REFERENCES [Ingredients] (IngredientId)
