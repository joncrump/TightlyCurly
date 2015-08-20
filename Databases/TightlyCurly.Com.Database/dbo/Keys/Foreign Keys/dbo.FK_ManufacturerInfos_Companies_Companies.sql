ALTER TABLE [dbo].[ManufacturerInfos_Companies]
	ADD CONSTRAINT [FK_ManufacturerInfos_Companies_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [Companies] (CompanyId)
