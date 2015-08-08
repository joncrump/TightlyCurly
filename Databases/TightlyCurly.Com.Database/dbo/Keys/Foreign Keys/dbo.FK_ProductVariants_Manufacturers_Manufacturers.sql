ALTER TABLE [dbo].[ProductVariants_Manufacturers]
	ADD CONSTRAINT [FK_ProductVariants_Manufacturers_Manufacturers]
	FOREIGN KEY (ManufacturerId)
	REFERENCES [Manufacturers] (ManufacturerId)
