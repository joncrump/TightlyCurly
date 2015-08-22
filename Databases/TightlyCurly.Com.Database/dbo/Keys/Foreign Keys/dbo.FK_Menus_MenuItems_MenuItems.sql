ALTER TABLE [dbo].[Menus_MenuItems]
	ADD CONSTRAINT [FK_Menus_MenuItems_MenuItems]
	FOREIGN KEY (MenuItemId)
	REFERENCES [dbo].[MenuItems] (MenuItemId)
