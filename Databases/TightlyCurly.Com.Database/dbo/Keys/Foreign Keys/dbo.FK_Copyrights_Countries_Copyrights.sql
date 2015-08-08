ALTER TABLE [dbo].[Copyrights_Countries]
	ADD CONSTRAINT [FK_Copyrights_Countries_Copyrights]
	FOREIGN KEY (CopyrightId)
	REFERENCES [Copyrights] (CopyrightId)
