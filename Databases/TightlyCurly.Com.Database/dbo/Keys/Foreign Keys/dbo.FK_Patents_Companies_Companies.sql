ALTER TABLE [dbo].[Patents_Companies]
	ADD CONSTRAINT [FK_Patents_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
