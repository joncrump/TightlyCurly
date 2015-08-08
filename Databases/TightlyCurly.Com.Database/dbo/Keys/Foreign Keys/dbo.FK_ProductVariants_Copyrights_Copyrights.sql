ALTER TABLE [dbo].[ProductVariants_Copyrights]
	ADD CONSTRAINT [FK_ProductVariants_Copyrights_Copyrights]
	FOREIGN KEY (CopyrightId)
	REFERENCES [Copyrights] (CopyrightId)
