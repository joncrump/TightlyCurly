CREATE TABLE [dbo].[IngredientRatings_IngredientRatingTexts]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[IngredientRatingId] UNIQUEIDENTIFIER NOT NULL,
	[IngredientRatingTextId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
