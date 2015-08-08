ALTER TABLE [dbo].[Companies_ContactInfos]
	ADD CONSTRAINT [FK_Companies_ContactInfos_Companies]
	FOREIGN KEY (CompanyId)
	REFERENCES [dbo].[Companies] (CompanyId)
