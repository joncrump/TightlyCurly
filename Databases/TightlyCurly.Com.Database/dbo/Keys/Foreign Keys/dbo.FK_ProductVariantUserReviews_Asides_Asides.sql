ALTER TABLE [dbo].[ProductVariantUserReviews_Asides]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_Asides_Asides]
	FOREIGN KEY (AsideId)
	REFERENCES [Asides] (AsideId)
