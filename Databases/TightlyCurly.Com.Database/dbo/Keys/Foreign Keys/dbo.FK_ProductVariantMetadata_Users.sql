ALTER TABLE [dbo].[ProductVariantMetadata]
	ADD CONSTRAINT [FK_ProductVariantMetadata_Users]
	FOREIGN KEY (EnteredBy)
	REFERENCES [Users] (UserId)
