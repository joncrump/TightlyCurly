ALTER TABLE [dbo].[ProductVariantNotes]
	ADD CONSTRAINT [FK_ProductVariantNotes_Users]
	FOREIGN KEY (EnteredBy)
	REFERENCES [Users] (UserId)
