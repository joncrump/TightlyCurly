ALTER TABLE [dbo].[ProductMetadata_ProductLines]
	ADD CONSTRAINT [FK_ProductMetadata_ProductLines_ProductLines]
	FOREIGN KEY (ProductLineId)
	REFERENCES [ProductLines] (ProductLineId)
