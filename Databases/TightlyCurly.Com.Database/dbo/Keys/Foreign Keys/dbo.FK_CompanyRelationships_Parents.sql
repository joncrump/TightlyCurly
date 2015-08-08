ALTER TABLE [dbo].[CompanyRelationships]
	ADD CONSTRAINT [FK_CompanyRelationships_Parents]
	FOREIGN KEY (ParentId)
	REFERENCES [CompanyRelationships] (CompanyRelationshipId)
