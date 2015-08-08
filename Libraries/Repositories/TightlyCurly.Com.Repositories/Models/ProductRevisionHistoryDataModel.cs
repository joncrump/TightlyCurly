using System;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductRevisionHistoryDataModel : ValueFactoryModelBase, IProductRevisionHistory
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IProductVariant PreviousVariant { get; set; }
        public IProductVariant CurrentVariant { get; set; }
        public string Comments { get; set; }
        public string Notes { get; set; }
    }
}
