ALTER TABLE [dbo].[ContentArticles]
	ADD CONSTRAINT [FK_ContentArticles_ContentItems]
	FOREIGN KEY (ContentItemId)
	REFERENCES [dbo].[ContentItems] (ContentItemId)
