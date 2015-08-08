ALTER TABLE [dbo].[ProductVariantUserReviews]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_Users]
	FOREIGN KEY (ReviewedBy)
	REFERENCES [Users] (UserId)
