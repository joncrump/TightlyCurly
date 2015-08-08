﻿CREATE TABLE [dbo].[Products]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
