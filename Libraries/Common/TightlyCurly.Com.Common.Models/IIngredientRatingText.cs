using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IIngredientRatingText : IModel
    {
        Guid IngredientRatingId { get; set; }
        string Text { get; set; }
        Guid? LocaleId { get; set; }
        ILocale Locale { get; set; }
    }
}
