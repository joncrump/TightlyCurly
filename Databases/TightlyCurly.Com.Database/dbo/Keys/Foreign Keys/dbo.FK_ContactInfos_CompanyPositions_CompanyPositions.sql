ALTER TABLE [dbo].[ContactInfos_CompanyPositions]
	ADD CONSTRAINT [FK_ContactInfos_CompanyPositions_CompanyPositions]
	FOREIGN KEY (CompanyPositionId)
	REFERENCES [CompanyPositions] (CompanyPositionId)
