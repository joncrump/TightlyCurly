ALTER TABLE [dbo].[PatentAuthors_Patents]
	ADD CONSTRAINT [FK_PatentAuthors_Patents_PatentAuthors]
	FOREIGN KEY (PatentAuthorId)
	REFERENCES [PatentAuthors] (PatentAuthorId)
