﻿CREATE TABLE [dbo].[Ingredients_ContentArticles]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[IngredientId] UNIQUEIDENTIFIER NOT NULL,
	[ContentArticleId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
