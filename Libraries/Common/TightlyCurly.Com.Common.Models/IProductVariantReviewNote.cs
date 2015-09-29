using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantReviewNote : IModel
    {
        string Note { get; set; }
        Guid ProductVariantReviewId { get; set; }
        Guid EnteredById { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
        IUser EnteredBy { get; set; }
    }
}
