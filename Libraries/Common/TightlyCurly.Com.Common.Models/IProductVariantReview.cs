using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantReview : IModel
    {
        decimal OverallRating { get; set; }
        Guid ProductVariantId { get; set; }
        
        IProductVariant ProductVariant { get; set; }
        IEnumerable<IProductVariantEditorialReview> EditorialReviews { get; set; }
        IEnumerable<IProductVariantUserReview> UserReviews { get; set; } 
        IEnumerable<IProductVariantReviewComment> Comments { get; set; }
        IEnumerable<IProductVariantReviewNote> Notes { get; set; }
    }
}
