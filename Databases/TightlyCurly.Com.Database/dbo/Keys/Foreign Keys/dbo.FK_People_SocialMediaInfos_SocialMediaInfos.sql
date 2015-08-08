ALTER TABLE [dbo].[People_SocialMediaInfos]
	ADD CONSTRAINT [FK_People_SocialMediaInfos_SocialMediaInfos]
	FOREIGN KEY (SocialMediaInfoId)
	REFERENCES [SocialMediaInfos] (SocialMediaInfoId)
