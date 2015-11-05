using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductSafetyInfo : IModel
    {
        ProductSafetyInfoType ProductSafetyInfoType { get; set; }
        string Text { get; set; }
        int? Order { get; set; }
        string Source { get; set; }
        Guid ProductVariantId { get; set; }
        Guid EnteredById { get; set; }
        Guid LocaleId { get; set; }
        string Notes { get; set; }
        bool? IsActive { get; set; }
        DateTime? EffectiveDate { get; set; }
        DateTime StopDate { get; set; }
        IEnumerable<IProductSafetyInfoComment> Comments { get; set; } 
        IProductVariant ProductVariant { get; set; }
        IUser EnteredBy { get; set; }
        ILocale Locale { get; set; }
    }
}
