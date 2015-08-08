ALTER TABLE [dbo].[ProductVariantUserReviews]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_Asides_ProductVariantUserReviews]
	FOREIGN KEY (ProductVariantUserReviewId)
	REFERENCES [ProductVariantUserReviews] (ProductVariantUserReviewId)
