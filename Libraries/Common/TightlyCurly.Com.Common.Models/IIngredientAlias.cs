using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IIngredientAlias : IModel
    {
        Guid IngredientId { set; }
        string Alias { get; set; }
        Guid LocaleId { get; set; }
        ILocale Locale { get; set; }
    }
}
