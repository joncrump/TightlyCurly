ALTER TABLE [dbo].[Brands_Copyrights]
	ADD CONSTRAINT [FK_Brands_Copyrights_Copyrights]
	FOREIGN KEY (CopyrightId)
	REFERENCES [Copyrights] (CopyrightId)
