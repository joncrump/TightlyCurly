using System;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductSafetyInfoDataModel : ValueFactoryModelBase, IProductSafetyInfo
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ProductSafetyInfoType ProductSafetyInfoType { get; set; }
        public string Text { get; set; }
    }
}
