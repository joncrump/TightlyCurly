ALTER TABLE [dbo].[ContentArticleData]
	ADD CONSTRAINT [FK_ContentArticleData_ContentArticles]
	FOREIGN KEY (ContentArticleId)
	REFERENCES [dbo].[ContentArticles] (ContentArticleId)
