using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantUserReview : IModel
    {
        int? Order { get; set; }
        Guid ReviewedById { get; set; }
        Guid ProductVariantReviewId { get; set; }
        string Review { get; set; }
        decimal? Rating { get; set; }
        DateTime ReviewDate { get; set; }
        bool? IsActive { get; set; }
        Guid? LocaleId { get; set; }
        IEnumerable<IAside> Asides { get; set; }
        IEnumerable<IProductVariantImageUri> ImageUris { get; set; }
        IUser ReviewedBy { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
        ILocale Locale { get; set; }
    }
}
