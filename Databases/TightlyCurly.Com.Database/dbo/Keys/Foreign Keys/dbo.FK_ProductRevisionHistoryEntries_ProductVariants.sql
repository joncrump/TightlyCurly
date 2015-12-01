ALTER TABLE [dbo].[ProductRevisionHistoryEntries]
	ADD CONSTRAINT [FK_ProductRevisionHistoryEntries_ProductVariants]
	FOREIGN KEY (ProductRevisionHistoryId)
	REFERENCES [dbo].[ProductVariants] (ProductVariantId)
