ALTER TABLE [dbo].[Companies]
	ADD CONSTRAINT [FK_Companies_ParentCompany]
	FOREIGN KEY (ParentCompanyId)
	REFERENCES [Companies] (CompanyId)
