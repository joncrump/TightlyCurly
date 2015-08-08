ALTER TABLE [dbo].[Markets_Countries]
	ADD CONSTRAINT [FK_Markets_Countries_Markets]
	FOREIGN KEY (MarketId)
	REFERENCES [Markets] (MarketId)
