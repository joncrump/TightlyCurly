ALTER TABLE [dbo].[Locations_Coordinates]
	ADD CONSTRAINT [FK_Locations_Coordinates_Coordinates]
	FOREIGN KEY (CoordinateId)
	REFERENCES [Coordinates] (CoordinateId)
