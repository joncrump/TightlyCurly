ALTER TABLE [dbo].[PatentAuthors_ContactInfos]
	ADD CONSTRAINT [FK_PatentAuthors_ContactInfos_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [dbo].[ContactInfos] (ContactInfoId)
