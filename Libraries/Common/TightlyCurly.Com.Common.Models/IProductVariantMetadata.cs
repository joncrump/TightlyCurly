using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantMetadata : IModel
    {
        string Key { get; set; }
        string Value { get; set; }
        Guid ProductVariantId { get; set; }
        Guid EnteredById { get; set; }
        IUser EnteredBy { get; set; }
        IProductVariant ProductVariant { get; set; }
    }
}
