ALTER TABLE [dbo].[ProductVariantReviewComments]
	ADD CONSTRAINT [UKC_ProductVariantReviewComments_ProductVariantReviewCommentId]
	UNIQUE (ProductVariantReviewCommentId)
