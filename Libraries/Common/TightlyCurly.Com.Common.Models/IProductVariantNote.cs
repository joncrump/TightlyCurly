using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantNote : IModel
    {
        Guid ProductVariantId { get; set; }
        Guid EnteredById { get; set; }
        string Text { get; set; }
        IUser EnteredBy { get; set; }
        IProductVariant ProductVariant { get; set; }
    }
}
