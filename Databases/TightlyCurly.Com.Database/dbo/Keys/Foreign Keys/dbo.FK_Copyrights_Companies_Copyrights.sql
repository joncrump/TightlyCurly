ALTER TABLE [dbo].[Copyrights_Companies]
	ADD CONSTRAINT [FK_Copyrights_Companies_Copyrights]
	FOREIGN KEY (CopyrightId)
	REFERENCES [Copyrights] (CopyrightId)
