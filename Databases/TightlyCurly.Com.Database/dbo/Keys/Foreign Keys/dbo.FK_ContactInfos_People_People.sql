ALTER TABLE [dbo].[ContactInfos_People]
	ADD CONSTRAINT [FK_ContactInfos_People_People]
	FOREIGN KEY (PersonId)
	REFERENCES [People] (PersonId)
