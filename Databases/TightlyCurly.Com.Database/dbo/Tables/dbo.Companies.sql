﻿CREATE TABLE [dbo].[Companies]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[CompanyId] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(255) NOT NULL,
	[ParentCompanyId] UNIQUEIDENTIFIER NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
