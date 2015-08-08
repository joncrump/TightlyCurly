ALTER TABLE [dbo].[ProductLines_Companies]
	ADD CONSTRAINT [FK_ProductLines_Companies_ProductLineId]
	FOREIGN KEY (ProductLineId)
	REFERENCES [ProductLines] (ProductLineId)
