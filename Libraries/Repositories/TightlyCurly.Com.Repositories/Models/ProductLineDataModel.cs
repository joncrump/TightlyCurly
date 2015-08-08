using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductLineDataModel : ValueFactoryModelBase, IProductLine
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
        public IEnumerable<ICompany> Companies { get; set; }
        public IEnumerable<ICopyright> Copyrights { get; set; }
        public IEnumerable<IPatent> Patents { get; set; }
        public IEnumerable<IProduct> Products { get; set; }
        public IEnumerable<ITrademark> Trademarks { get; set; }
    }
}
