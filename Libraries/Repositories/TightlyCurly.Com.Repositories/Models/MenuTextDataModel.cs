using System;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class MenuTextDataModel : ValueFactoryModelBase, IMenuText
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid MenuId { get; set; }
        public Guid LocaleId { get; set; }
        public ILocale Locale { get; set; }
        public string Text { get; set; }
    }
}
