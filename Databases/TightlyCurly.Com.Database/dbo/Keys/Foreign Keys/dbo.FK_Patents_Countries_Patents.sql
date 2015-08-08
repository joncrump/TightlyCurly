ALTER TABLE [dbo].[Patents_Countries]
	ADD CONSTRAINT [FK_Patents_Countries_Patents]
	FOREIGN KEY (PatentId)
	REFERENCES [Patents] (PatentId)
