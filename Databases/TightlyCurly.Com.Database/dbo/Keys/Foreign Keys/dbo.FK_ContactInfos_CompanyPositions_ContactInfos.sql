ALTER TABLE [dbo].[ContactInfos_CompanyPositions]
	ADD CONSTRAINT [FK_ContactInfos_CompanyPositions_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [ContactInfos] (ContactInfoId)
