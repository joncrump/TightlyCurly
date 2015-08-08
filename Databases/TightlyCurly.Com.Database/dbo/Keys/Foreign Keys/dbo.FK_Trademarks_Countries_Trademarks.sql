ALTER TABLE [dbo].[Trademarks_Countries]
	ADD CONSTRAINT [FK_Trademarks_Countries_Trademarks]
	FOREIGN KEY (TrademarkId)
	REFERENCES [Trademarks] (TrademarkId)
