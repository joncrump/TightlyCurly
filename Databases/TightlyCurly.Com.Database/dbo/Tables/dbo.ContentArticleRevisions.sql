CREATE TABLE [dbo].[ContentArticleRevisions]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ContentArticleRevisionId] UNIQUEIDENTIFIER NOT NULL,
	[ContentArticleId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL,
	[VersionNumber] NVARCHAR(10) NOT NULL,
	[IsCurrent] BIT NOT NULL,
	[Notes] NVARCHAR(1000) NULL,
)
