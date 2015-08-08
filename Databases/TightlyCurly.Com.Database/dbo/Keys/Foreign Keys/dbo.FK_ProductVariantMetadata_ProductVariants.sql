ALTER TABLE [dbo].[ProductVariantMetadata]
	ADD CONSTRAINT [FK_ProductVariantMetadata_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
