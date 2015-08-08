using System;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductVariantMetadataDataModel : ValueFactoryModelBase, IProductVariantMetadata
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public IUser EnteredBy { get; set; }
    }
}
