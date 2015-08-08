ALTER TABLE [dbo].[ContactInfos_Addresses]
	ADD CONSTRAINT [FK_ContactInfos_Addresses_Addresses]
	FOREIGN KEY (AddressId)
	REFERENCES [Addresses] (AddressId)
