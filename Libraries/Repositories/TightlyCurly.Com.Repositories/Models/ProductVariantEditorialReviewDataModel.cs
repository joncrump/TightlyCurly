using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductVariantEditorialReviewDataModel : ValueFactoryModelBase, IProductVariantEditorialReview
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? Order { get; set; }
        public IUser ReviewedBy { get; set; }
        public string Review { get; set; }
        public decimal? Rating { get; set; }
        public IEnumerable<IAside> Asides { get; set; }
        public IEnumerable<IImageUri> ImageUris { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
