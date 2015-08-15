ALTER TABLE [dbo].[IngredientComments]
	ADD CONSTRAINT [UKC_IngredientComments_IngredientCommentId]
	UNIQUE (IngredientCommentId)
