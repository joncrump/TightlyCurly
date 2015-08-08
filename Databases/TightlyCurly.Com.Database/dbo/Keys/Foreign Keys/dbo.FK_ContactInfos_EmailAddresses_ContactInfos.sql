ALTER TABLE [dbo].[ContactInfos_EmailAddresses]
	ADD CONSTRAINT [FK_ContactInfos_EmailAddresses_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [ContactInfos] (ContactInfoId)
