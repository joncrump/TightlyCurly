using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common.Model.Enums;

namespace TightlyCurly.Com.Common.Models
{
    public interface IMessageTemplate : IModel, ITextEntry
    {
        Guid LocaleId { get; set; }
        string TemplateName { get; set; }
        IEnumerable<IMessageTemplateToken> MessageTemplateTokens { get; set; }
    }
}
