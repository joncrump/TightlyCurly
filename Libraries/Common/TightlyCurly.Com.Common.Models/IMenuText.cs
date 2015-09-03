using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IMenuText : IModel
    {
        Guid MenuId { get; set; }
        Guid LocaleId { get; set; }
        IMenu Menu { get; set; }
        ILocale Locale { get; set; }
        string Text { get; set; }
    }
}
