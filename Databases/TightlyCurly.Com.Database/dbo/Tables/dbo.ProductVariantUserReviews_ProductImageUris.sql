CREATE TABLE [dbo].[ProductVariantUserReviews_ProductImageUris]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantUserReviewId] UNIQUEIDENTIFIER NOT NULL,
	[ProductImageUriId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
