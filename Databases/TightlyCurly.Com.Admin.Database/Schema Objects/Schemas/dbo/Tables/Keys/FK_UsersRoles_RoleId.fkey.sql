﻿ALTER TABLE [dbo].[UsersRoles]
    ADD CONSTRAINT [FK_UsersRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([RoleId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

