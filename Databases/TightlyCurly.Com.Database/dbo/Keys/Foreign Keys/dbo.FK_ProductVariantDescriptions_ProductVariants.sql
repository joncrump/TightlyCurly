ALTER TABLE [dbo].[ProductVariantDescriptions]
	ADD CONSTRAINT [FK_ProductVariantDescriptions_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
