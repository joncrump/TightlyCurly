using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IIngredientRatingText : IModel
    {
        string Text { get; set; }
        Guid? LocaleId { get; set; }
        ILocale Locale { get; set; }
    }
}
