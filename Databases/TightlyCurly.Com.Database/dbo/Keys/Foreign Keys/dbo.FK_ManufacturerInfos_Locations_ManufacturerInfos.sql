ALTER TABLE [dbo].[ManufacturerInfos_Locations]
	ADD CONSTRAINT [FK_ManufacturerInfos_Locations_ManufacturerInfos]
	FOREIGN KEY (ManufacturerInfoId)
	REFERENCES [dbo].[ManufacturerInfos] (ManufacturerInfoId)
