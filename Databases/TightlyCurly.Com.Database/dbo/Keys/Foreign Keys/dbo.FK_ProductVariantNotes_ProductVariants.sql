ALTER TABLE [dbo].[ProductVariantNotes]
	ADD CONSTRAINT [FK_ProductVariantNotes_ProductVariants]
	FOREIGN KEY (ProductVariantId)
	REFERENCES [ProductVariants] (ProductVariantId)
