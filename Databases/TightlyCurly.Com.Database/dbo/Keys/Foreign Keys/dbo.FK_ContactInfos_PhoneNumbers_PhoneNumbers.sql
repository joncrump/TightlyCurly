ALTER TABLE [dbo].[ContactInfos_PhoneNumbers]
	ADD CONSTRAINT [FK_ContactInfos_PhoneNumbers_PhoneNumbers]
	FOREIGN KEY (PhoneNumberId)
	REFERENCES [PhoneNumbers] (PhoneNumberId)
