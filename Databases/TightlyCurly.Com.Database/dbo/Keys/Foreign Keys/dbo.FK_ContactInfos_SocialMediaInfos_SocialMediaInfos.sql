ALTER TABLE [dbo].[ContactInfos_SocialMediaInfos]
	ADD CONSTRAINT [FK_ContactInfos_SocialMediaInfos_SocialMediaInfos]
	FOREIGN KEY (SocialMediaInfoId)
	REFERENCES [SocialMediaInfos] (SocialMediaInfoId)
