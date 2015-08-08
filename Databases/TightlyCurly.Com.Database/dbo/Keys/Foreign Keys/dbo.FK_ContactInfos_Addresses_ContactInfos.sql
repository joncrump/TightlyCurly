ALTER TABLE [dbo].[ContactInfos_Addresses]
	ADD CONSTRAINT [FK_ContactInfos_Addresses_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [ContactInfos] (ContactInfoId)
