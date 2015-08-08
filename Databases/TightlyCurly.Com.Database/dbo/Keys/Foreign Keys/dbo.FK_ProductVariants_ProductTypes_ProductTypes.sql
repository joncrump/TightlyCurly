ALTER TABLE [dbo].[ProductVariants_ProductTypes]
	ADD CONSTRAINT [FK_ProductVariants_ProductTypes_ProductTypes]
	FOREIGN KEY (ProductTypeId)
	REFERENCES [ProductTypes] (ProductTypeId)
