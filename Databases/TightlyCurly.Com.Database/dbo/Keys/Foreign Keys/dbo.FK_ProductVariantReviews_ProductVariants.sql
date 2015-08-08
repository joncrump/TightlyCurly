ALTER TABLE [dbo].[ProductVariantReviews]
	ADD CONSTRAINT [FK_ProductVariantReviews_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
