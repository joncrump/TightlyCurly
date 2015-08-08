using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class MarketDataModel : ValueFactoryModelBase, IMarket
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; }
        public IEnumerable<ICountry> Countries { get; set; }
        public IEnumerable<ICoordinates> Vertices { get; set; }
    }
}
