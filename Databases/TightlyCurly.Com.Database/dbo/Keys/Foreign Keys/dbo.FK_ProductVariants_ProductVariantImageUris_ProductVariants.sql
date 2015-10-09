ALTER TABLE [dbo].[ProductVariants_ProductVariantImageUris]
	ADD CONSTRAINT [FK_ProductVariants_ProductVariantImageUris_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
