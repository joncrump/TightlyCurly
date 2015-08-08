CREATE TABLE [dbo].[EmailAddresses]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[EmailAddressId] UNIQUEIDENTIFIER NOT NULL,
	[Address] NVARCHAR(255) NOT NULL,
	[Verified] BIT NULL,
	[IsPrimary] BIT NULL,
	[IsActive] BIT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
