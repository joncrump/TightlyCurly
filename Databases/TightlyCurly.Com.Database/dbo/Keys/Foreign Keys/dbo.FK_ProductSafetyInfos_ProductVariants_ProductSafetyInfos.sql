ALTER TABLE [dbo].[ProductSafetyInfos_ProductVariants]
	ADD CONSTRAINT [FK_ProductSafetyInfos_ProductVariants_ProductSafetyInfos]
	FOREIGN KEY (ProductSafetyInfoId)
	REFERENCES [ProductSafetyInfos] (ProductSafetyInfoId)
