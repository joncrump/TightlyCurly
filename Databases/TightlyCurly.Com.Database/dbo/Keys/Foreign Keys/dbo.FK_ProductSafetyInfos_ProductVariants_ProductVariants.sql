ALTER TABLE [dbo].[ProductSafetyInfos_ProductVariants]
	ADD CONSTRAINT [FK_ProductSafetyInfos_ProductVariants_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
