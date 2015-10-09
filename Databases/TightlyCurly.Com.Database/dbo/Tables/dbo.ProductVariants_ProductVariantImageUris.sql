CREATE TABLE [dbo].[ProductVariants_ProductVariantImageUris]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantImageUriId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
