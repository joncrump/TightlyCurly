ALTER TABLE [dbo].[Menus_MenuItems]
	ADD CONSTRAINT [FK_Menus_MenuItems_Menus]
	FOREIGN KEY (MenuId)
	REFERENCES [dbo].[Menus] (MenuId)
