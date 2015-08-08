ALTER TABLE [dbo].[ContentArticleNotes]
	ADD CONSTRAINT [FK_ContentArticleNotes_ContentArticles]
	FOREIGN KEY (ContentArticleId)
	REFERENCES [dbo].[ContentArticles] (ContentArticleId)
