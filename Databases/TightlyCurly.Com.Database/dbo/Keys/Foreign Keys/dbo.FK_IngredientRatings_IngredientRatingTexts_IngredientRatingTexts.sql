ALTER TABLE [dbo].[IngredientRatings_IngredientRatingTexts]
	ADD CONSTRAINT [FK_IngredientRatings_IngredientRatingTexts_IngredientRatingTexts]
	FOREIGN KEY (IngredientRatingTextId)
	REFERENCES [dbo].[IngredientRatingTexts] (IngredientRatingTextId)
