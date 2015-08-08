ALTER TABLE [dbo].[ManufacturerInfo_Companies]
	ADD CONSTRAINT [FK_ManufacturerInfo_Companies_ManufacturerInfo]
	FOREIGN KEY (ManufacturerInfoId)
	REFERENCES [ManufacturerInfo] (ManufacturerInfoId)
