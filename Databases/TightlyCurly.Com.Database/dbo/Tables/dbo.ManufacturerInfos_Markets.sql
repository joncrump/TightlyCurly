﻿CREATE TABLE [dbo].[ManufacturerInfos_Markets]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ManufacturerInfoId] UNIQUEIDENTIFIER NOT NULL,
	[MarketId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)