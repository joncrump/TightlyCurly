CREATE TABLE [dbo].[CompanyRelationships_RelationshipTypes]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[CompanyRelationshipId] UNIQUEIDENTIFIER NOT NULL,
	[RelationshipTypeId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
