ALTER TABLE [dbo].[Addresses]
	ADD CONSTRAINT [FK_Addresses_Counties]
	FOREIGN KEY (CountyId)
	REFERENCES [dbo].[Counties] (CountyId)
