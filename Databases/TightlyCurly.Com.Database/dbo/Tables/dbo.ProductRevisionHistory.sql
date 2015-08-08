CREATE TABLE [dbo].[ProductRevisionHistory]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[ProductRevisionHistoryId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantId] UNIQUEIDENTIFIER NOT NULL,
	[PreviousVariant] XML NOT NULL,
	[CurrentVariant] XML NOT NULL,
	[Comments] NVARCHAR(MAX) NULL,
	[Notes] NVARCHAR(MAX) NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
