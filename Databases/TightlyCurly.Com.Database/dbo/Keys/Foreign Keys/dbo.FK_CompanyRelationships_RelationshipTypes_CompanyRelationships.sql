ALTER TABLE [dbo].[CompanyRelationships_RelationshipTypes]
	ADD CONSTRAINT [FK_CompanyRelationships_RelationshipTypes_CompanyRelationships]
	FOREIGN KEY (CompanyRelationshipId)
	REFERENCES [dbo].[CompanyRelationships] (CompanyRelationshipId)
