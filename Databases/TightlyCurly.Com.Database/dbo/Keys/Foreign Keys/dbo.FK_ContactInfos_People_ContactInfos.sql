ALTER TABLE [dbo].[ContactInfos_People]
	ADD CONSTRAINT [FK_ContactInfos_People_ContactInfos]
	FOREIGN KEY (ContactInfoId)
	REFERENCES [ContactInfos] (ContactInfoId)
