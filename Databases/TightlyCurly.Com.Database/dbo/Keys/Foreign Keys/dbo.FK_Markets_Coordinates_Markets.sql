ALTER TABLE [dbo].[Markets_Coordinates]
	ADD CONSTRAINT [FK_Markets_Coordinates_Markets]
	FOREIGN KEY (MarketId)
	REFERENCES [Markets] (MarketId)
