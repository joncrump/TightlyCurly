﻿CREATE TABLE [dbo].[MenuItemTexts]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[MenuItemTextId] UNIQUEIDENTIFIER NOT NULL,
	[MenuItemId] UNIQUEIDENTIFIER NOT NULL,
	[LocaleId] UNIQUEIDENTIFIER NOT NULL,
	[Text] NVARCHAR(255) NOT NULL,
	[Description] NVARCHAR(1000) NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
