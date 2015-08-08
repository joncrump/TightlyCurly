CREATE TABLE [dbo].[Roles] (
    [RoleId]      INT             IDENTITY (1, 1) NOT NULL,
    [RoleName]    NVARCHAR (255)  NOT NULL,
    [Description] NVARCHAR (4000) NOT NULL
);

