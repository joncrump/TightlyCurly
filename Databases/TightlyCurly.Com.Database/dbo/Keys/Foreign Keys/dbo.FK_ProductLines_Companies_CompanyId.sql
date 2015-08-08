ALTER TABLE [dbo].[ProductLines_Companies]
	ADD CONSTRAINT [FK_ProductLines_Companies_CompanyId]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
