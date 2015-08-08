ALTER TABLE [dbo].[ProductVariants_ProductImageUris]
	ADD CONSTRAINT [FK_ProductVariants_ProductImageUris_ProductImageUris]
	FOREIGN KEY (ProductImageUriId)
	REFERENCES [ProductImageUris] (ProductImageUriId)
