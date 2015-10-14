ALTER TABLE [dbo].[ProductVariantUserReviews_ProductVariantImageUris]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_ProductImageUris_ProductVariantImageUris]
	FOREIGN KEY (ProductVariantImageUriId)
	REFERENCES [dbo].[ProductVariantImageUris] (ProductVariantImageUriId)
