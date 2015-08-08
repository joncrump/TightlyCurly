ALTER TABLE [dbo].[ProductVariantSkus]
	ADD CONSTRAINT [FK_ProductVariantSkus_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
