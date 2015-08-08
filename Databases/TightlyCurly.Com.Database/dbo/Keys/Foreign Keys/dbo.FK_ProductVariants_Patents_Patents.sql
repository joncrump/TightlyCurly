ALTER TABLE [dbo].[ProductVariants_Patents]
	ADD CONSTRAINT [FK_ProductVariants_Patents_Patents]
	FOREIGN KEY (PatentId)
	REFERENCES [Patents] (PatentId)
