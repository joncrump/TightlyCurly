ALTER TABLE [dbo].[ProductVariantEditorialReviews_Asides]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_Asides_Asides]
	FOREIGN KEY (AsideId)
	REFERENCES [Asides] (AsideId)
