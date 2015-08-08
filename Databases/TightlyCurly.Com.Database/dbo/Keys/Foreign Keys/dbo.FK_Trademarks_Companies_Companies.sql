ALTER TABLE [dbo].[Trademarks_Companies]
	ADD CONSTRAINT [FK_Trademarks_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
