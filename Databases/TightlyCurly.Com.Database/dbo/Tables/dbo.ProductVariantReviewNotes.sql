CREATE TABLE [dbo].[ProductVariantReviewNotes]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ProductVariantReviewNoteId] UNIQUEIDENTIFIER NOT NULL
	/*
	string Note { get; set; }
        Guid ProductVariantReviewId { get; set; }
        Guid EnteredById { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
        IUser EnteredBy { get; set; }
	*/
)
