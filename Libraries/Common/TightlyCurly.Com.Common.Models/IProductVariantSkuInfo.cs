using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantSkuInfo : IModel
    {
        Guid ProductVariantId { get; set; }
        string Sku { get; set; }
        IProductVariant ProductVariant { get; set; }
    }
}
