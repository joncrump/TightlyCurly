ALTER TABLE [dbo].[MenuItems]
	ADD CONSTRAINT [FK_MenuItems_MenuItems]
	FOREIGN KEY (ParentId)
	REFERENCES [dbo].[MenuItems] (MenuItemId)
