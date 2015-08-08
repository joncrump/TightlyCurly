ALTER TABLE [dbo].[Manufacturers_Companies]
	ADD CONSTRAINT [FK_Manufacturers_Companies_Manufacturers]
	FOREIGN KEY (ManufacturerId)
	REFERENCES [Manufacturers] (ManufacturerId)
