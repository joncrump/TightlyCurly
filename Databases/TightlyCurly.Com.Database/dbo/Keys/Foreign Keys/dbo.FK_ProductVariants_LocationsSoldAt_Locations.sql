ALTER TABLE [dbo].[ProductVariants_LocationsSoldAt]
	ADD CONSTRAINT [FK_ProductVariants_LocationsSoldAt_Locations]
	FOREIGN KEY (LocationId)
	REFERENCES [Locations] (LocationId)
