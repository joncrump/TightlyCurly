ALTER TABLE [dbo].[ProductVariants_LocationsSoldAt]
	ADD CONSTRAINT [FK_ProductVariants_LocationsSoldAt_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
