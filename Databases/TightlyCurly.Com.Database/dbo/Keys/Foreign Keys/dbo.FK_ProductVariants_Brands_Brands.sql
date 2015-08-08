ALTER TABLE [dbo].[ProductVariants_Brands]
	ADD CONSTRAINT [FK_ProductVariants_Brands_Brands]
	FOREIGN KEY (BrandId)
	REFERENCES [Brands] (BrandId)
