ALTER TABLE [dbo].[ManufacturerInfo_Companies]
	ADD CONSTRAINT [FK_ManufacturerInfo_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
