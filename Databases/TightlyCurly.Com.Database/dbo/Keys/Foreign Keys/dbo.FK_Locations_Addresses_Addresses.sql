ALTER TABLE [dbo].[Locations_Addresses]
	ADD CONSTRAINT [FK_Locations_Addresses_Addresses]
	FOREIGN KEY (AddressId)
	REFERENCES [Addresses] (AddressId)
