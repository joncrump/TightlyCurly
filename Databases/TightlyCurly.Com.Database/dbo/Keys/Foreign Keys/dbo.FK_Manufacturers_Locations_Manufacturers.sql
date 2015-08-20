ALTER TABLE [dbo].[Manufacturers_Locations]
	ADD CONSTRAINT [FK_Manufacturers_Locations_Manufacturers]
	FOREIGN KEY (ManufacturerId)
	REFERENCES [dbo].[Manufacturers] (ManufacturerId)
