ALTER TABLE [dbo].[ManufacturerInfos_Markets]
	ADD CONSTRAINT [FK_ManufacturerInfos_Markets_ManufacturerInfos]
	FOREIGN KEY (ManufacturerInfoId)
	REFERENCES [dbo].[ManufacturerInfos] (ManufacturerInfoId)
