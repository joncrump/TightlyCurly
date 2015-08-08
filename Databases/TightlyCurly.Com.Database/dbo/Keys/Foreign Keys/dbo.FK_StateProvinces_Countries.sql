ALTER TABLE [dbo].[StateProvinces]
	ADD CONSTRAINT [FK_StateProvinces_Countries]
	FOREIGN KEY (CountryId)
	REFERENCES [Countries] (CountryId)
