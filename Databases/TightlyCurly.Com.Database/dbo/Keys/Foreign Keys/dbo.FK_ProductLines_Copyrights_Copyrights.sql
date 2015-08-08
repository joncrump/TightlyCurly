ALTER TABLE [dbo].[ProductLines_Copyrights]
	ADD CONSTRAINT [FK_ProductLines_Copyrights_Copyrights]
	FOREIGN KEY (CopyrightId)
	REFERENCES [Copyrights] (CopyrightId)
