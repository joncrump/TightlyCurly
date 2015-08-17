﻿CREATE TABLE [dbo].[IngredientRatingTexts]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[IngredientRatingTextId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientRatingId] UNIQUEIDENTIFIER NOT NULL,
	[Text] NVARCHAR(255) NOT NULL,
	[LocaleId] UNIQUEIDENTIFIER NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
