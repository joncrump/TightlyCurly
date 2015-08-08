ALTER TABLE [dbo].[ProductVariantEditorialReviews]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_ProductVariantReviews]
	FOREIGN KEY (ProductVariantReviewId)
	REFERENCES [ProductVariantReviews] (ProductVariantReviewId)
