ALTER TABLE [dbo].[MenuItemTexts]
	ADD CONSTRAINT [FK_MenuItemTexts_MenuItems]
	FOREIGN KEY (MenuItemId)
	REFERENCES [dbo].[MenuItems] (MenuItemId)
