ALTER TABLE [dbo].[ProductVariantReviewNotes]
	ADD CONSTRAINT [FK_ProductVariantReviewNotes_Users]
	FOREIGN KEY (EnteredById)
	REFERENCES [dbo].[Users] (UserId)
