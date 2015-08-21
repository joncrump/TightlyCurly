﻿CREATE TABLE [dbo].[ManufacturerInfos_Locations]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ManufacturerInfoId] UNIQUEIDENTIFIER NOT NULL,
	[LocationId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)