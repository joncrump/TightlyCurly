ALTER TABLE [dbo].[ProductVariants_ProductImageUris]
	ADD CONSTRAINT [FK_ProductVariants_ProductImageUris_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
