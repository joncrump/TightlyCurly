ALTER TABLE [dbo].[ContentArticleRevisions]
	ADD CONSTRAINT [FK_ContentArticleRevisions_ContentArticles]
	FOREIGN KEY (ContentArticleId)
	REFERENCES [ContentArticles] (ContentArticleId)
