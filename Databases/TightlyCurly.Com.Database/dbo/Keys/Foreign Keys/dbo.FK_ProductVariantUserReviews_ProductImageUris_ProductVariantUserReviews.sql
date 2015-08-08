ALTER TABLE [dbo].[ProductVariantUserReviews_ProductImageUris]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_ProductImageUris_ProductVariantUserReviews]
	FOREIGN KEY (ProductVariantUserReviewId)
	REFERENCES [ProductVariantUserReviews] (ProductVariantUserReviewId)
