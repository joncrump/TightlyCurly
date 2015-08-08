ALTER TABLE [dbo].[ContactInfos_EmailAddresses]
	ADD CONSTRAINT [FK_ContactInfos_EmailAddresses_EmailAddresses]
	FOREIGN KEY (EmailAddressId)
	REFERENCES [EmailAddresses] (EmailAddressId)
