ALTER TABLE [dbo].[Companies_ContactInfos]
	ADD CONSTRAINT [FK_Companies_ContactInfos_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [dbo].[ContactInfos] (ContactInfoId)
