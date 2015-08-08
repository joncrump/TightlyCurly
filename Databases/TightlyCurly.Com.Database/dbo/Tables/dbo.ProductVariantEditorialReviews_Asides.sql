CREATE TABLE [dbo].[ProductVariantEditorialReviews_Asides]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantEditorialReviewId] UNIQUEIDENTIFIER NOT NULL,
	[AsideId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
