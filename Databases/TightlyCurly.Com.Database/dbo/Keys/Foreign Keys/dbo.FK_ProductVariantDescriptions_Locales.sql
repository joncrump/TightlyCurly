ALTER TABLE [dbo].[ProductVariantDescriptions]
	ADD CONSTRAINT [FK_ProductVariantDescriptions_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
