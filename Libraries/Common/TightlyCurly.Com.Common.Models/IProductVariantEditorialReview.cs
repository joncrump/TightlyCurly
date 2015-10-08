using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantEditorialReview : IModel
    {
        int? Order { get; set; }
        Guid ProductVariantReviewId { get; set; }
        Guid ReviewedById { get; set; }
        DateTime ReviewDate { get; set; }
        bool? IsActive { get; set; }
        string Review { get; set; }
        decimal? Rating { get; set; }
        IEnumerable<IAside> Asides { get; set; }
        IEnumerable<IProductVariantImageUri> ImageUris { get; set; }
        IUser ReviewedBy { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
    }
}
    