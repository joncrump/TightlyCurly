using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductVariantReviewDataModel : ValueFactoryModelBase, IProductVariantReview
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IEnumerable<IProductVariantEditorialReview> EditorialReviews { get; set; }
        public IEnumerable<IProductVariantUserReview> UserReviews { get; set; }
        public decimal OverallRating { get; set; }
        public IEnumerable<string> Comments { get; set; }
        public IEnumerable<string> Notes { get; set; }
    }
}
