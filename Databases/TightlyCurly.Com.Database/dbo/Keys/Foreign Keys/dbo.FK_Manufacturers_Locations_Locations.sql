ALTER TABLE [dbo].[Manufacturers_Locations]
	ADD CONSTRAINT [FK_Manufacturers_Locations_Locations]
	FOREIGN KEY (LocationId)
	REFERENCES [dbo].[Locations] (LocationId)
