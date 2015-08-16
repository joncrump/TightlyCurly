ALTER TABLE [dbo].[IngredientRatingTexts]
	ADD CONSTRAINT [FK_IngredientRatingTexts_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
