ALTER TABLE [dbo].[IngredientNotes]
	ADD CONSTRAINT [FK_IngredientNotes_Users]
	FOREIGN KEY (EnteredByUserId)
	REFERENCES [dbo].[Users] (UserId)
