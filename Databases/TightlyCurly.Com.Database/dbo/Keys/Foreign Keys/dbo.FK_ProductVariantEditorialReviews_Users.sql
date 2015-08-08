ALTER TABLE [dbo].[ProductVariantEditorialReviews]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_Users]
	FOREIGN KEY (ReviewedBy)
	REFERENCES [Users] (UserId)
