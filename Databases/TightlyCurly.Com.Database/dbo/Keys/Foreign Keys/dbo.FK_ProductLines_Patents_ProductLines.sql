ALTER TABLE [dbo].[ProductLines_Patents]
	ADD CONSTRAINT [FK_ProductLines_Patents_ProductLines]
	FOREIGN KEY (ProductLineId)
	REFERENCES [ProductLines] (ProductLineId)
