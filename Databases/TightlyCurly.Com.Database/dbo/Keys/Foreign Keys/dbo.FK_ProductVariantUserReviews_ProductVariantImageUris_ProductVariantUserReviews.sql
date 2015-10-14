ALTER TABLE [dbo].[ProductVariantUserReviews_ProductVariantImageUris]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_ProductVariantImageUris_ProductVariantUserReviews]
	FOREIGN KEY (ProductVariantUserReviewId)
	REFERENCES [ProductVariantUserReviews] (ProductVariantUserReviewId)
