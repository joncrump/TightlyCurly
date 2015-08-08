﻿CREATE TABLE [dbo].[ProductImageUris]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductImageUriId] UNIQUEIDENTIFIER NOT NULL,
	[ProductId] UNIQUEIDENTIFIER NOT NULL,
	[Uri] NVARCHAR(1000) NOT NULL,
	[Description] NVARCHAR(4000) NULL,
	[AltText] NVARCHAR(4000) NULL,
	[IsPrimary] BIT NULL,
	[Order] INT NULL,
	[Active] BIT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
