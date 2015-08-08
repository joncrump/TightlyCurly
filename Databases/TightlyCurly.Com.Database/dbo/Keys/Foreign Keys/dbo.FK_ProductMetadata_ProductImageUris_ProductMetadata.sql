ALTER TABLE [dbo].[ProductMetadata_ProductImageUris]
	ADD CONSTRAINT [FK_ProductMetadata_ProductImageUris_ProductMetadata]
	FOREIGN KEY (ProductMetadataId)
	REFERENCES [ProductMetadata] (ProductMetadataId)
