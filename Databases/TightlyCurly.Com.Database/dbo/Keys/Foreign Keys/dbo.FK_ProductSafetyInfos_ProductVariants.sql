ALTER TABLE [dbo].[ProductSafetyInfos]
	ADD CONSTRAINT [FK_ProductSafetyInfos_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [dbo].[ProductVariants] (ProductVariantId)
