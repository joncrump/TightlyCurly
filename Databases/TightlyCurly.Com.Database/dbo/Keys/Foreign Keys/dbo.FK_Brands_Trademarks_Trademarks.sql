ALTER TABLE [dbo].[Brands_Trademarks]
	ADD CONSTRAINT [FK_Brands_Trademarks_Trademarks]
	FOREIGN KEY (TrademarkId)
	REFERENCES [Trademarks] (TrademarkId)
