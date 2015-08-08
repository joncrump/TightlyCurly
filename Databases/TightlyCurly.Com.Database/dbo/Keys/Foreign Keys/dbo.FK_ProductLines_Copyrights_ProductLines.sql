ALTER TABLE [dbo].[ProductLines_Copyrights]
	ADD CONSTRAINT [FK_ProductLines_Copyrights_ProductLines]
	FOREIGN KEY (ProductLineId)
	REFERENCES [ProductLines] (ProductLineId)
