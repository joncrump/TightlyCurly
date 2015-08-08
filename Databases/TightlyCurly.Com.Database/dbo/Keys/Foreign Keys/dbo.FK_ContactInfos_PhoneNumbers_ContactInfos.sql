ALTER TABLE [dbo].[ContactInfos_PhoneNumbers]
	ADD CONSTRAINT [FK_ContactInfos_PhoneNumbers_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [ContactInfos] (ContactInfoId)
