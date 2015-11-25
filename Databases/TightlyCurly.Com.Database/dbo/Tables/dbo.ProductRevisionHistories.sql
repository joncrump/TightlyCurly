﻿CREATE TABLE [dbo].[ProductRevisionHistories]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductRevisionHistoryId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
