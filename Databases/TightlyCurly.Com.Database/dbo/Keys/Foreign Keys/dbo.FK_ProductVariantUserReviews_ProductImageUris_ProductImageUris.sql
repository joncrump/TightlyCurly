ALTER TABLE [dbo].[ProductVariantUserReviews_ProductImageUris]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_ProductImageUris_ProductImageUris]
	FOREIGN KEY (ProductImageUriId)
	REFERENCES [ProductImageUris] (ProductImageUriId)
