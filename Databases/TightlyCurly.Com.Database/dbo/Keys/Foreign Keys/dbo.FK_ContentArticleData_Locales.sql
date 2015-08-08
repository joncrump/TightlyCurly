ALTER TABLE [dbo].[ContentArticleData]
	ADD CONSTRAINT [FK_ContentArticleData_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
