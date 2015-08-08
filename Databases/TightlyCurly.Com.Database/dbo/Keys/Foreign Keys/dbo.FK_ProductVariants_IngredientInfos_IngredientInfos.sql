ALTER TABLE [dbo].[ProductVariants_IngredientInfos]
	ADD CONSTRAINT [FK_ProductVariants_IngredientInfos_IngredientInfos]
	FOREIGN KEY (IngredientInfoId)
	REFERENCES [IngredientInfos] (IngredientInfoId)
