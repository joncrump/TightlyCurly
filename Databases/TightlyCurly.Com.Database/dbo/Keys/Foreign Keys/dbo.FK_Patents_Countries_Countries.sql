ALTER TABLE [dbo].[Patents_Countries]
	ADD CONSTRAINT [FK_Patents_Countries_Countries]
	FOREIGN KEY (CountryId)
	REFERENCES [Countries] (CountryId)
