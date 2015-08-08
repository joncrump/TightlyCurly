ALTER TABLE [dbo].[PatentAuthors_Patents]
	ADD CONSTRAINT [FK_PatentAuthors_Patents_Patents]
	FOREIGN KEY (PatentId)
	REFERENCES [Patents] (PatentId)
