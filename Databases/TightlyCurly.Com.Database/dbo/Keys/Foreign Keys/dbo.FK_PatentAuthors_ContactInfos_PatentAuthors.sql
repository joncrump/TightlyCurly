ALTER TABLE [dbo].[PatentAuthors_ContactInfos]
	ADD CONSTRAINT [FK_PatentAuthors_ContactInfos_PatentAuthors]
	FOREIGN KEY (PatentAuthorId)
	REFERENCES [dbo].[PatentAuthors] (PatentAuthorId)
