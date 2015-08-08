using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductMetadataDataModel : ValueFactoryModelBase, IProductMetadata
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IEnumerable<IBrand> Brands { get; set; }
        public IProduct Product { get; set; }
        public Guid ProductId { get; set; }
        public string Title { get; set; }
        public IEnumerable<IProductLine> ProductLines { get; set; }
        public IEnumerable<IImageUri> ImageUris { get; set; }
    }
}
