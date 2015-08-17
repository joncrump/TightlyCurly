ALTER TABLE [dbo].[IngredientRatingTexts]
	ADD CONSTRAINT [FK_IngredientRatingTexts_IngredientRatings]
	FOREIGN KEY (IngredientRatingId)
	REFERENCES [dbo].[IngredientRatings] (IngredientRatingId)
