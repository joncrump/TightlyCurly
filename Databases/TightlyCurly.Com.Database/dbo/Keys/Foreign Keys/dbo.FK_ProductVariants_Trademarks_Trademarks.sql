ALTER TABLE [dbo].[ProductVariants_Trademarks]
	ADD CONSTRAINT [FK_ProductVariants_Trademarks_Trademarks]
	FOREIGN KEY (TrademarkId)
	REFERENCES [dbo].[Trademarks] (TrademarkId)
