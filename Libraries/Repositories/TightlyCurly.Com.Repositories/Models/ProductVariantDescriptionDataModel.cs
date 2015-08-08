using System;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductVariantDescriptionDataModel : IProductVariantDescription
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }
        public IUser EnteredBy { get; set; }
    }
}
