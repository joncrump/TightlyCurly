ALTER TABLE [dbo].[ManufacturerInfos_Companies]
	ADD CONSTRAINT [FK_ManufacturerInfos_Companies_ManufacturerInfo]
	FOREIGN KEY (ManufacturerInfoId)
	REFERENCES [ManufacturerInfos] (ManufacturerInfoId)
