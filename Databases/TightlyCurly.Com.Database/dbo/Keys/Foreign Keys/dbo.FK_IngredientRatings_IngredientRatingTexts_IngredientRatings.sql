ALTER TABLE [dbo].[IngredientRatings_IngredientRatingTexts]
	ADD CONSTRAINT [FK_IngredientRatings_IngredientRatingTexts_IngredientRatings]
	FOREIGN KEY (IngredientRatingId)
	REFERENCES [dbo].[IngredientRatings] (IngredientRatingId)
