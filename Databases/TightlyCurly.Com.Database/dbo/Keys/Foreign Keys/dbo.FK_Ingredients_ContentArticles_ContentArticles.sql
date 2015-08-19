ALTER TABLE [dbo].[Ingredients_ContentArticles]
	ADD CONSTRAINT [FK_Ingredients_ContentArticles_ContentArticles]
	FOREIGN KEY (ContentArticleId)
	REFERENCES [dbo].[ContentArticles] (ContentArticleId)
