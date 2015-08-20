ALTER TABLE [dbo].[ManufacturerInfos_Locations]
	ADD CONSTRAINT [FK_ManufacturerInfos_Locations_Locations]
	FOREIGN KEY (LocationId)
	REFERENCES [dbo].[Locations] (LocationId)
