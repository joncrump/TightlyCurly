ALTER TABLE [dbo].[Copyrights_Companies]
	ADD CONSTRAINT [FK_Copyrights_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
