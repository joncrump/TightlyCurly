﻿ALTER TABLE [dbo].[ProductVariantEditorialReviews_ProductVariantImageUris]
	ADD CONSTRAINT [FK_ProductVariantEditorialReviews_ProductVariantImageUris_ProductVariantEditorialReviews]
	FOREIGN KEY (ProductVariantEditorialReviewId)
	REFERENCES [dbo].[ProductVariantEditorialReviews] (ProductVariantEditorialReviewId)
