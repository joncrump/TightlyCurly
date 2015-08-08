﻿CREATE TABLE [dbo].[ProductVariants]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[ProductId] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(100) NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
