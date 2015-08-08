using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductDataModel : ValueFactoryModelBase, IProduct
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IEnumerable<IProductMetadata> ProductMetadata { get; set; }
        public IEnumerable<IProductVariant> Variants { get; set; }
    }
}
