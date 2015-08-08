CREATE TABLE [dbo].[Users] (
    [UserId]                  INT             IDENTITY (1, 1) NOT NULL,
    [Username]                NVARCHAR (255)  NOT NULL,
    [EmailAddress]            NVARCHAR (255)  NOT NULL,
    [IsLockedOut]             BIT             NULL,
    [PasswordQuestion]        NVARCHAR (255)  NOT NULL,
    [PasswordAnswer]          NVARCHAR (1000) NOT NULL,
    [Comment]                 NVARCHAR (255)  NULL,
    [Password]                NVARCHAR (1000) NOT NULL,
    [IsApproved]              BIT             NULL,
    [CreationDate]            SMALLDATETIME   NULL,
    [LastLoginDate]           SMALLDATETIME   NULL,
    [LastActivityDate]        SMALLDATETIME   NULL,
    [LastPasswordChangedDate] SMALLDATETIME   NULL,
    [LastLockoutDate]         SMALLDATETIME   NULL
);

