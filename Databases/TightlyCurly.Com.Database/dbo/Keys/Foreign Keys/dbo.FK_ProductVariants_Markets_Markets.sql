ALTER TABLE [dbo].[ProductVariants_Markets]
	ADD CONSTRAINT [FK_ProductVariants_Markets_Markets]
	FOREIGN KEY (MarketId)
	REFERENCES [Markets] (MarketId)
