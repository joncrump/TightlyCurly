ALTER TABLE [dbo].[ProductSafetyInfos]
	ADD CONSTRAINT [FK_ProductSafetyInfos_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
