ALTER TABLE [dbo].[Menus_ContentItems]
	ADD CONSTRAINT [FK_Menus_ContentItems_ContentItems]
	FOREIGN KEY (ContentItemId)
	REFERENCES [dbo].[ContentItems] (ContentItemId)
