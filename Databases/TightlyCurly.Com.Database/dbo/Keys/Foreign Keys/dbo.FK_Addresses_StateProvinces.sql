ALTER TABLE [dbo].[Addresses]
	ADD CONSTRAINT [FK_Addresses_StateProvinces]
	FOREIGN KEY (StateProvinceId)
	REFERENCES [StateProvinces] (StateProvinceId)
