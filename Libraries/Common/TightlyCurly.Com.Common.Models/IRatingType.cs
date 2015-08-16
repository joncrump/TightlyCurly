using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IRatingType : IModel
    {
		string Type { get; set; }
        string Description { get; set; }
        Guid? LocaleId { get; set; }
        ILocale Locale { get; set; }
    }
}
