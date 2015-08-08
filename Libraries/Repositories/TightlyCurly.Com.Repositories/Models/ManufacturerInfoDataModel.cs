using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ManufacturerInfoDataModel : IManufacturerInfo
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid ManufacturerId { get; set; }
        public string Name { get; set; }
        public IEnumerable<ICompany> ManufacturedBy { get; set; }
        public IEnumerable<ILocation> ManufacturedAt { get; set; }
        public IEnumerable<IMarket> ManufacturedForMarkets { get; set; }
    }
}
