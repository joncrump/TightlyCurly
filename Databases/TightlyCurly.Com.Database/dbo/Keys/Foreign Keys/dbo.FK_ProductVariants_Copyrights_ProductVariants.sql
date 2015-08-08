ALTER TABLE [dbo].[ProductVariants_Copyrights]
	ADD CONSTRAINT [FK_ProductVariants_Copyrights_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
