ALTER TABLE [dbo].[ProductMetadata_Brands]
	ADD CONSTRAINT [FK_ProductMetadata_Brands_ProductMetadata]
	FOREIGN KEY (ProductMetadataId)
	REFERENCES [ProductMetadata] (ProductMetadataId)
