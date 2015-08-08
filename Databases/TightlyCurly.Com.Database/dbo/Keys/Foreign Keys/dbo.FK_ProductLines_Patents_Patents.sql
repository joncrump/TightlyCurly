ALTER TABLE [dbo].[ProductLines_Patents]
	ADD CONSTRAINT [FK_ProductLines_Patents_Patents]
	FOREIGN KEY (PatentId)
	REFERENCES [Patents] (PatentId)
