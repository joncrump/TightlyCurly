ALTER TABLE [dbo].[ProductVariantReviewComments]
	ADD CONSTRAINT [FK_ProductVariantReviewComments_Users]
	FOREIGN KEY (EnteredById)
	REFERENCES [dbo].[Users] (UserId)
