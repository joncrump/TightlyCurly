ALTER TABLE [dbo].[PatentAuthors_SocialMediaInfos]
	ADD CONSTRAINT [FK_PatentAuthors_SocialMediaInfos_SocialMediaInfos]
	FOREIGN KEY (SocialMediaInfoId)
	REFERENCES [dbo].[SocialMediaInfos] (SocialMediaInfoId)
