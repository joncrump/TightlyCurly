ALTER TABLE [dbo].[Addresses]
	ADD CONSTRAINT [FK_Addresses_Countries]
	FOREIGN KEY (CountryId)
	REFERENCES [dbo].[Countries] (CountryId)
