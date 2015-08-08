ALTER TABLE [dbo].[ProductMetadata_Brands]
	ADD CONSTRAINT [FK_ProductMetadata_Brands_Brands]
	FOREIGN KEY (BrandId)
	REFERENCES [Brands] (BrandId)
