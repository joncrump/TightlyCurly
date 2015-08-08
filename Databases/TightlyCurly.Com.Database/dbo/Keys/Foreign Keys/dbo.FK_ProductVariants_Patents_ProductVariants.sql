ALTER TABLE [dbo].[ProductVariants_Patents]
	ADD CONSTRAINT [FK_ProductVariants_Patents_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
