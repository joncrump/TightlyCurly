﻿CREATE TABLE [dbo].[ProductVariants_ProductTypes]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[ProductTypeId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
