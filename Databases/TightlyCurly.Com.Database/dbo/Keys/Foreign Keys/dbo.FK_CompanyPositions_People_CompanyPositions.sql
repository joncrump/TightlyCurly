ALTER TABLE [dbo].[CompanyPositions_People]
	ADD CONSTRAINT [FK_CompanyPositions_People_CompanyPositions]
	FOREIGN KEY (CompanyPositionId)
	REFERENCES [CompanyPositions] (CompanyPositionId)
