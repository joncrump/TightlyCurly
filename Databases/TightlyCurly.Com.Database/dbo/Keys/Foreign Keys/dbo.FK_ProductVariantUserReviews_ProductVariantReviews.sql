﻿ALTER TABLE [dbo].[ProductVariantUserReviews]
	ADD CONSTRAINT [FK_ProductVariantUserReviews_ProductVariantReviews]
	FOREIGN KEY (ProductVariantReviewId)
	REFERENCES [ProductVariantReviews] (ProductVariantReviewId)
