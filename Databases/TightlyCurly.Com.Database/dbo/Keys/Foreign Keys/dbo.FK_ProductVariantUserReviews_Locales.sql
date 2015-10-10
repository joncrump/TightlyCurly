ALTER TABLE [dbo].[ProductVariantUserReviews]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
