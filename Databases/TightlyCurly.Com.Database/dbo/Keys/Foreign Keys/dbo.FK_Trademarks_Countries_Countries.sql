ALTER TABLE [dbo].[Trademarks_Countries]
	ADD CONSTRAINT [FK_Trademarks_Countries_Countries]
	FOREIGN KEY (CountryId)
	REFERENCES [Countries] (CountryId)
