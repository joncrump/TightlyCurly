ALTER TABLE [dbo].[Manufacturers_Companies]
	ADD CONSTRAINT [FK_Manufacturers_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
