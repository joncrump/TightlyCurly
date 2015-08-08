ALTER TABLE [dbo].[ProductVariants_IngredientInfos]
	ADD CONSTRAINT [FK_ProductVariants_IngredientInfos_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
