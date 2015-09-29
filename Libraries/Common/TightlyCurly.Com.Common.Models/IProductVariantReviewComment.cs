using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantReviewComment : IModel
    {
        string Comment { get; set; }
        Guid ProductVariantReviewId { get; set; }
        Guid EnteredById { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
        IUser EnteredBy { get; set; }
    }
}
