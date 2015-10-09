﻿CREATE TABLE [dbo].[ProductVariantImageUris]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductVariantImageUriId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[Uri] NVARCHAR(1000) NOT NULL,
	[Description] NVARCHAR(4000) NULL,
	[AltText] NVARCHAR(4000) NULL,
	[IsPrimary] BIT NULL,
	[Order] INT NULL,
	[IsActive] BIT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
