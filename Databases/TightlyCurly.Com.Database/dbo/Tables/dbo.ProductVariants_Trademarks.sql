CREATE TABLE [dbo].[ProductVariants_Trademarks]
(
	[Id] INT NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[TrademarkId] UNIQUEIDENTIFIER NOT NULL,
	[DateEntered] SMALLDATETIME NOT NULL,
	[DateLastUpdated] SMALLDATETIME NOT NULL
)
