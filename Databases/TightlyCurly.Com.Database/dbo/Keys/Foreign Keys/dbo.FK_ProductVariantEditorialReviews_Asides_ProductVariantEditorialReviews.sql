ALTER TABLE [dbo].[ProductVariantEditorialReviews_Asides]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_Asides_ProductVariantEditorialReviews]
	FOREIGN KEY (ProductVariantEditorialReviewId)
	REFERENCES [ProductVariantEditorialReviews] (ProductVariantEditorialReviewId)
