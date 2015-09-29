using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantDescription : IModel
    {
        Guid ProductVariantId { get; set; }
        Guid EnteredById { get; set; }
        Guid LocaleId { get; set; }
        string Description { get; set; }
        IUser EnteredBy { get; set; }
        IProductVariant ProductVariant { get; set; }
        ILocale Locale { get; set; }
    }
}
