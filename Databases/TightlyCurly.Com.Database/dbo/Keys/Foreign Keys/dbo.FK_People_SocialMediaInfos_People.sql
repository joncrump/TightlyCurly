ALTER TABLE [dbo].[People_SocialMediaInfos]
	ADD CONSTRAINT [FK_People_SocialMediaInfos_People]
	FOREIGN KEY (PersonId)
	REFERENCES [People] (PersonId)
