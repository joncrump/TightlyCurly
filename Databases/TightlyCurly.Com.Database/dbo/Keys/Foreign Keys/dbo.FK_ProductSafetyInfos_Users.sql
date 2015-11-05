ALTER TABLE [dbo].[ProductSafetyInfos]
	ADD CONSTRAINT [FK_ProductSafetyInfos_Users]
	FOREIGN KEY (EnteredById)
	REFERENCES [dbo].[Users] (UserId)
