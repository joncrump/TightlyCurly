ALTER TABLE [dbo].[Locations_Coordinates]
	ADD CONSTRAINT [FK_Locations_Coordinates_Locations]
	FOREIGN KEY (LocationId)
	REFERENCES [Locations] (LocationId)
