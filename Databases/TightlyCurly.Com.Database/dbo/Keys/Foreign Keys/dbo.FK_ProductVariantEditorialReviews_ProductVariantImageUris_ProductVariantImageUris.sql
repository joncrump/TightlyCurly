ALTER TABLE [dbo].[ProductVariantEditorialReviews_ProductVariantImageUris]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_ProductVariantImageUris_ProductImageUris]
	FOREIGN KEY (ProductVariantImageUriId)
	REFERENCES [dbo].[ProductVariantImageUris] (ProductVariantImageUriId)
