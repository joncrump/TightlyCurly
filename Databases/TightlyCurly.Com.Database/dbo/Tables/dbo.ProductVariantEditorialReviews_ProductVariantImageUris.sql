CREATE TABLE [dbo].[ProductVariantEditorialReviews_ProductVariantImageUris]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantEditorialReviewId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantImageUriId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
