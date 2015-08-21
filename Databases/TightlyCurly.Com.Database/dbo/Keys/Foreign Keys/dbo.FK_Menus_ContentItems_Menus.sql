ALTER TABLE [dbo].[Menus_ContentItems]
	ADD CONSTRAINT [FK_Menus_ContentItems_Menus]
	FOREIGN KEY (MenuId)
	REFERENCES [dbo].[Menus] (MenuId)
