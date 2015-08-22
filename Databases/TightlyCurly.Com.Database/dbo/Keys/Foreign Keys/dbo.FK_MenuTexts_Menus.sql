ALTER TABLE [dbo].[MenuTexts]
	ADD CONSTRAINT [FK_MenuTexts_Menus]
	FOREIGN KEY (MenuId)
	REFERENCES [dbo].[Menus] (MenuId)
