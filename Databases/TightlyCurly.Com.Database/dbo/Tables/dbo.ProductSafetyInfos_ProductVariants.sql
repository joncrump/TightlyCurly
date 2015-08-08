CREATE TABLE [dbo].[ProductSafetyInfos_ProductVariants]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductSafetyInfoId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL

)
