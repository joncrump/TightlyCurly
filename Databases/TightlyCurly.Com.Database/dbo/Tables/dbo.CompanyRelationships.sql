﻿CREATE TABLE [dbo].[CompanyRelationships]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[CompanyRelationshipId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL,
	[StartDate] SMALLDATETIME NULL,
	[EndDate] SMALLDATETIME NULL,
	[Name] NVARCHAR(255) NOT NULL,
	[Notes] NVARCHAR(1000) NULL,
	[ParentId] UNIQUEIDENTIFIER NULL,
)
