﻿CREATE TABLE [dbo].[CompanyPositions_People]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[CompanyPositionId] UNIQUEIDENTIFIER NOT NULL,
	[PersonId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
