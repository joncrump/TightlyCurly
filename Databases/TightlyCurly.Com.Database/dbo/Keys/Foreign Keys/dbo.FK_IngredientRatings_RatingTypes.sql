ALTER TABLE [dbo].[IngredientRatings]
	ADD CONSTRAINT [FK_IngredientRatings_RatingTypes]
	FOREIGN KEY (RatingTypeId)
	REFERENCES [dbo].[RatingTypes] (RatingTypeId)
