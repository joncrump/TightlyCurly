ALTER TABLE [dbo].[Patents_Companies]
	ADD CONSTRAINT [FK_Patents_Companies_Patents]
	FOREIGN KEY (PatentId)
	REFERENCES [Patents] (PatentId)
