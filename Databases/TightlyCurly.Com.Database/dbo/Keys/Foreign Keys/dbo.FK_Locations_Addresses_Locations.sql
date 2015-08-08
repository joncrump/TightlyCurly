ALTER TABLE [dbo].[Locations_Addresses]
	ADD CONSTRAINT [FK_Locations_Addresses_Locations]
	FOREIGN KEY (LocationId)
	REFERENCES [Locations] (LocationId)
