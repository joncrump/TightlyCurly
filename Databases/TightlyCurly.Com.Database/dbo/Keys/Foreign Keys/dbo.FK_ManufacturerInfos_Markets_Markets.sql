ALTER TABLE [dbo].[ManufacturerInfos_Markets]
	ADD CONSTRAINT [FK_ManufacturerInfos_Markets_Markets]
	FOREIGN KEY (MarketId)
	REFERENCES [dbo].[Markets] (MarketId)
