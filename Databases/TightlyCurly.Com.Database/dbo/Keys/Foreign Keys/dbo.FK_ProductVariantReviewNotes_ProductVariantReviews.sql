ALTER TABLE [dbo].[ProductVariantReviewNotes]
	ADD CONSTRAINT [FK_ProductVariantReviewNotes_ProductVariantReviews]
	FOREIGN KEY (ProductVariantReviewId)
	REFERENCES [dbo].[ProductVariantReviews] (ProductVariantReviewId)
