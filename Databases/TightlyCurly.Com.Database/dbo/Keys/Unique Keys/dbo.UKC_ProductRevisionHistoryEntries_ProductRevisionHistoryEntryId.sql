ALTER TABLE [dbo].[ProductRevisionHistoryEntries]
	ADD CONSTRAINT [UKC_ProductRevisionHistoryEntries_ProductRevisionHistoryEntryId]
	UNIQUE (ProductRevisionHistoryEntryId)
