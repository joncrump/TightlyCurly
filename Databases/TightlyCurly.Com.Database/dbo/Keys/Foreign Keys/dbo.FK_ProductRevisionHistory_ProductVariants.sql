ALTER TABLE [dbo].[ProductRevisionHistory]
	ADD CONSTRAINT [FK_ProductRevisionHistory_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
