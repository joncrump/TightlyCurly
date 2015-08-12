﻿CREATE TABLE [dbo].[ContentItems]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ContentItemId] UNIQUEIDENTIFIER NOT NULL,
	[Title] NVARCHAR(200) NOT NULL,
	[IsActive] BIT NULL,
	[Uri] NVARCHAR(1000) NOT NULL,
	[Name] NVARCHAR(200) NOT NULL,
	[MetaDescription] NVARCHAR(1000) NULL,
	[MetaKeywords] NVARCHAR(1000) NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
