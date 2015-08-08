ALTER TABLE [dbo].[CompanyPositions_Companies]
	ADD CONSTRAINT [FK_CompanyPositions_Companies_CompanyPositions]
	FOREIGN KEY (CompanyPositionId)
	REFERENCES [CompanyPositions] (CompanyPositionId)
