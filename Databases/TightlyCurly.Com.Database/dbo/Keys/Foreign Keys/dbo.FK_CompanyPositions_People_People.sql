ALTER TABLE [dbo].[CompanyPositions_People]
	ADD CONSTRAINT [FK_CompanyPositions_People_People]
	FOREIGN KEY (PersonId)
	REFERENCES [People] (PersonId)
