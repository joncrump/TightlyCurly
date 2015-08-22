﻿CREATE TABLE [dbo].[Menus_MenuItems]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[MenuId] UNIQUEIDENTIFIER NOT NULL,
	[MenuItemId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
