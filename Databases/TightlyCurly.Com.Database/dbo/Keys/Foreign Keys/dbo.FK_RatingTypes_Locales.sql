ALTER TABLE [dbo].[RatingTypes]
	ADD CONSTRAINT [FK_RatingTypes_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
