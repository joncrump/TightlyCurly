ALTER TABLE [dbo].[Brands]
	ADD CONSTRAINT [FK_Brands_Manufacturers]
	FOREIGN KEY (ManufacturerId)
	REFERENCES [Manufacturers] (ManufacturerId)
