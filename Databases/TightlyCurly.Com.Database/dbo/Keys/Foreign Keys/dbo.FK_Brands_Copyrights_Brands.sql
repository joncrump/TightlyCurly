ALTER TABLE [dbo].[Brands_Copyrights]
	ADD CONSTRAINT [FK_Brands_Copyrights_Brands]
	FOREIGN KEY (BrandId)
	REFERENCES [Brands] (BrandId)
