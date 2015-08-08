ALTER TABLE [dbo].[Copyrights_Countries]
	ADD CONSTRAINT [FK_Copyrights_Countries_Countries]
	FOREIGN KEY (CountryId)
	REFERENCES [Countries] (CountryId)
