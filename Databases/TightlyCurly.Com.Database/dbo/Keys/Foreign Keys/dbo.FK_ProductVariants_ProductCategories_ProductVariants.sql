ALTER TABLE [dbo].[ProductVariants_ProductCategories]
	ADD CONSTRAINT [FK_ProductVariants_ProductCategories_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
