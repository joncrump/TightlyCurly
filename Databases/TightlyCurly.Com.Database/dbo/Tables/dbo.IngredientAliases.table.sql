﻿CREATE TABLE [dbo].[IngredientAliases]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IngredientAliasId]	UNIQUEIDENTIFIER NOT NULL, 
	[IngredientId] UNIQUEIDENTIFIER	NOT NULL,
	[IngredientAlias] NVARCHAR(255)		NOT NULL,
	[LocaleId] INT NOT NULL,
	[EnteredDate] SMALLDATETIME	NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
