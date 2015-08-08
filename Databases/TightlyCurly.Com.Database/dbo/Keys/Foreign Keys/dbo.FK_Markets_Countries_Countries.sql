ALTER TABLE [dbo].[Markets_Countries]
	ADD CONSTRAINT [FK_Markets_Countries_Countries]
	FOREIGN KEY (CountryId)
	REFERENCES [Countries] (CountryId)
