using System;
using System.Collections;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductRevisionHistory : IModel
    {
        Guid ProductVariantId { get; set; }
        IProductVariant ProductVariant { get; set; }
        IEnumerable<IProductRevisionHistoryEntry> Entries { get; set; }
    }
}
