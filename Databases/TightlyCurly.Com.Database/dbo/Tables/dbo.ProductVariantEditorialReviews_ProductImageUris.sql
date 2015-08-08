CREATE TABLE [dbo].[ProductVariantEditorialReviews_ProductImageUris]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantEditorialReviewId] UNIQUEIDENTIFIER NOT NULL,
	[ProductImageUriId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
