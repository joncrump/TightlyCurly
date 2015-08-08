ALTER TABLE [dbo].[ProductVariants_Manufacturers]
	ADD CONSTRAINT [FK_ProductVariants_Manufacturers_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
