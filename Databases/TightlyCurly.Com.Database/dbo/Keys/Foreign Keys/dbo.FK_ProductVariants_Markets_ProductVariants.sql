ALTER TABLE [dbo].[ProductVariants_Markets]
	ADD CONSTRAINT [FK_ProductVariants_Markets_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
