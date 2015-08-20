﻿CREATE TABLE [dbo].[Manufacturers_Locations]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ManufacturerId] UNIQUEIDENTIFIER NOT NULL,
	[LocationId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
