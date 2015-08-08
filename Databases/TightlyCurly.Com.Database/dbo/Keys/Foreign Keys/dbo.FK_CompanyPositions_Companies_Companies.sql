ALTER TABLE [dbo].[CompanyPositions_Companies]
	ADD CONSTRAINT [FK_CompanyPositions_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
