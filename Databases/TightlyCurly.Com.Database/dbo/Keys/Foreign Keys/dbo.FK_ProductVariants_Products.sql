ALTER TABLE [dbo].[ProductVariants]
	ADD CONSTRAINT [FK_ProductVariants_Products]
	FOREIGN KEY (ProductId)
	REFERENCES [Products] (ProductId)
