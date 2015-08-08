ALTER TABLE [dbo].[ProductVariantEditorialReviews_ProductImageUris]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_ProductImageUris_ProductImageUris]
	FOREIGN KEY (ProductImageUriId)
	REFERENCES [ProductImageUris] (ProductImageUriId)
