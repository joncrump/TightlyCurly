using System;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductCategoryDataModel : IProductCategory
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
    }
}
