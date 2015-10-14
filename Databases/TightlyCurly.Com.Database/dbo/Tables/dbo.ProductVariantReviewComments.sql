CREATE TABLE [dbo].[ProductVariantReviewComments]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantReviewCommentId] UNIQUEIDENTIFIER NOT NULL,
	[ProductVariantReviewId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredById] UNIQUEIDENTIFIER NOT NULL,
	/*
	        string Comment { get; set; }
        Guid ProductVariantReviewId { get; set; }
        Guid EnteredById { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
        IUser EnteredBy { get; set; }
	*/
)
