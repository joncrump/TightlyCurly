ALTER TABLE [dbo].[ProductVariantReviewComments]
	ADD CONSTRAINT [FK_ProductVariantReviewComments_ProductVariantReviews]
	FOREIGN KEY (ProductVariantReviewId)
	REFERENCES [dbo].[ProductVariantReviews] (ProductVariantReviewId)
