ALTER TABLE [dbo].[ProductVariantDescriptions]
	ADD CONSTRAINT [FK_ProductVariantDescriptions_Users]
	FOREIGN KEY (EnteredBy)
	REFERENCES [Users] (UserId)
