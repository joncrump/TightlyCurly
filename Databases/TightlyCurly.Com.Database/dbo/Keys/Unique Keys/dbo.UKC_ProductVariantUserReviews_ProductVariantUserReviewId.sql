ALTER TABLE [dbo].[ProductVariantUserReviews]
	ADD CONSTRAINT [UKC_ProductVariantUserReviews_ProductVariantUserReviewId]
	UNIQUE (ProductVariantUserReviewId)
