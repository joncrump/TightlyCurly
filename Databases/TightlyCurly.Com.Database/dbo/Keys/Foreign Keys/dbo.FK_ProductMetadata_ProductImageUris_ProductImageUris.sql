ALTER TABLE [dbo].[ProductMetadata_ProductImageUris]
	ADD CONSTRAINT [FK_ProductMetadata_ProductImageUris_ProductImageUris]
	FOREIGN KEY (ProductImageUriId)
	REFERENCES [ProductImageUris] (ProductImageUriId)
