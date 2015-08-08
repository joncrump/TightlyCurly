ALTER TABLE [dbo].[ProductMetadata_ProductLines]
	ADD CONSTRAINT [FK_ProductMetadata_ProductLines_ProductMetadata]
	FOREIGN KEY (ProductMetadataId)
	REFERENCES [ProductMetadata] (ProductMetadataId)
