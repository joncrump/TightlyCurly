ALTER TABLE [dbo].[ProductVariants_ProductCategories]
	ADD CONSTRAINT [FK_ProductVariants_ProductCategories_ProductCategories]
	FOREIGN KEY (ProductCategoryId)
	REFERENCES [ProductCategories] (ProductCategoryId)
