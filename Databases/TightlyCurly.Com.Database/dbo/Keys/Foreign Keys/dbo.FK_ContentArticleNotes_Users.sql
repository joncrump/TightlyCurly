ALTER TABLE [dbo].[ContentArticleNotes]
	ADD CONSTRAINT [FK_ContentArticleNotes_Users]
	FOREIGN KEY (EnteredByUserId)
	REFERENCES [dbo].[Users] (UserId)
