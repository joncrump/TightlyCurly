ALTER TABLE [dbo].[CompanyRelationships_RelationshipTypes]
	ADD CONSTRAINT [FK_CompanyRelationships_RelationshipTypes_RelationshipTypes]
	FOREIGN KEY (RelationshipTypeId)
	REFERENCES [dbo].[RelationshipTypes] (RelationshipTypeId)
