ALTER TABLE [dbo].[Brands_Trademarks]
	ADD CONSTRAINT [FK_Brands_Trademarks_Brands]
	FOREIGN KEY (BrandId)
	REFERENCES [Brands] (BrandId)
