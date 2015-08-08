ALTER TABLE [dbo].[ContactInfos_SocialMediaInfos]
	ADD CONSTRAINT [FK_ContactInfos_SocialMediaInfos_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [ContactInfos] (ContactInfoId)
