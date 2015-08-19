CREATE TABLE [dbo].[Locales] (
	[Id] INT IDENTITY(1,1) NOT NULL,
    [LocaleId]    UNIQUEIDENTIFIER NOT NULL,
    [LCID]        INT           NULL,
    [LocaleName]  NVARCHAR (40) NOT NULL,
    [EnteredDate] SMALLDATETIME NOT NULL,
    [UpdatedDate] SMALLDATETIME NOT NULL,
	[Code]		NVARCHAR(50) NULL
);

