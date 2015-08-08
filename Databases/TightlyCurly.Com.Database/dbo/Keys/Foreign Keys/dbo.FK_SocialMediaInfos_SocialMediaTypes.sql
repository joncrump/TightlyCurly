ALTER TABLE [dbo].[SocialMediaInfos]
	ADD CONSTRAINT [FK_SocialMediaInfos_SocialMediaTypes]
	FOREIGN KEY (SocialMediaTypeId)
	REFERENCES [SocialMediaTypes] (SocialMediaTypeId)
