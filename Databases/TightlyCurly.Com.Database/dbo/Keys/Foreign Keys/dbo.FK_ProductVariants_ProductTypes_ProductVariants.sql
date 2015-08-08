ALTER TABLE [dbo].[ProductVariants_ProductTypes]
	ADD CONSTRAINT [FK_ProductVariants_ProductTypes_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
