ALTER TABLE [dbo].[ProductRevisionHistoryEntries]
	ADD CONSTRAINT [FK_ProductRevisionHistoryEntries_ProductRevisionHistories]
	FOREIGN KEY (ProductRevisionHistoryId)
	REFERENCES [dbo].[ProductRevisionHistories] (ProductRevisionHistoryId)
