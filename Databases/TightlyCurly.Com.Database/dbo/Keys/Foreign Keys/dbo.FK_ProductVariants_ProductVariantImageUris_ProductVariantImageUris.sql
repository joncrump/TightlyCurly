ALTER TABLE [dbo].[ProductVariants_ProductVariantImageUris]
	ADD CONSTRAINT [FK_ProductVariants_ProductVariantImageUris_ProductVariantImageUris]
	FOREIGN KEY (ProductVariantImageUriId)
	REFERENCES [dbo].[ProductVariantImageUris] (ProductVariantImageUriId)
