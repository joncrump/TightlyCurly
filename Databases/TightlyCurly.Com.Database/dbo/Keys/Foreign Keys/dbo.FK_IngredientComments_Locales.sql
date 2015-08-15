ALTER TABLE [dbo].[IngredientComments]
	ADD CONSTRAINT [FK_IngredientComments_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
