ALTER TABLE [dbo].[ProductVariants_Brands]
	ADD CONSTRAINT [FK_ProductVariants_Brands_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
