CREATE TABLE [dbo].[ProductRevisionHistoryEntries]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductRevisionHistoryEntryId] UNIQUEIDENTIFIER NOT NULL,
	[ProductRevisionHistoryId] UNIQUEIDENTIFIER NOT NULL,
	[OldIngredients] XML NOT NULL,
	[NewIngredients] XML NOT NULL,
	[Comments] NVARCHAR(MAX) NULL,
	[Notes] NVARCHAR(MAX) NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
