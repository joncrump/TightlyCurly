ALTER TABLE [dbo].[ProductMetadata]
	ADD CONSTRAINT [FK_ProductMetadata_Products]
	FOREIGN KEY (ProductId)
	REFERENCES [Products] (ProductId)
