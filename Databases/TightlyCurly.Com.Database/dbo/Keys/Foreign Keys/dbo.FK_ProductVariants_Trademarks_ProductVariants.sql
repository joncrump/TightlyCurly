ALTER TABLE [dbo].[ProductVariants_Trademarks]
	ADD CONSTRAINT [FK_ProductVariants_Trademarks_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [dbo].[ProductVariants] (ProductVariantId)
