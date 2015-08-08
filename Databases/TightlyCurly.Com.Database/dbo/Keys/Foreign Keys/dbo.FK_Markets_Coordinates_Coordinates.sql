ALTER TABLE [dbo].[Markets_Coordinates]
	ADD CONSTRAINT [FK_Markets_Coordinates_Coordinates]
	FOREIGN KEY (CoordinateId)
	REFERENCES [Coordinates] (CoordinateId)
