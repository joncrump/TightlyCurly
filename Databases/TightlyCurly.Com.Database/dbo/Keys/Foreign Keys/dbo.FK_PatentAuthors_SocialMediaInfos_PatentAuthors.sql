ALTER TABLE [dbo].[PatentAuthors_SocialMediaInfos]
	ADD CONSTRAINT [FK_PatentAuthors_SocialMediaInfos_PatentAuthors]
	FOREIGN KEY (PatentAuthorId)
	REFERENCES [dbo].[PatentAuthors] (PatentAuthorId)
