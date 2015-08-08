CREATE TABLE [dbo].[ProductVariants_ProductCategories]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[ProductCategoryId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
