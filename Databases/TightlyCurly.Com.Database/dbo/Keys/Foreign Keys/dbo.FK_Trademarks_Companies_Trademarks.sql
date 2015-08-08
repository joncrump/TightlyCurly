ALTER TABLE [dbo].[Trademarks_Companies]
	ADD CONSTRAINT [FK_Trademarks_Companies_Trademarks]
	FOREIGN KEY (TrademarkId)
	REFERENCES [Trademarks] (TrademarkId)
