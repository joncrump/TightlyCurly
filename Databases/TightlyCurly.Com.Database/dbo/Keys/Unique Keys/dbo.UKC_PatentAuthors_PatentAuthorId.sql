ALTER TABLE [dbo].[PatentAuthors]
	ADD CONSTRAINT [UKC_PatentAuthors_PatentAuthorId]
	UNIQUE (PatentAuthorId)
