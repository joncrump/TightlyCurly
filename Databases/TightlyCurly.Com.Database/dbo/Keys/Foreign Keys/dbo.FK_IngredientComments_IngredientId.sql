ALTER TABLE [dbo].[IngredientComments]
	ADD CONSTRAINT [FK_IngredientComments_IngredientId]
	FOREIGN KEY (IngredientId)
	REFERENCES [dbo].[Ingredients] (IngredientId)
