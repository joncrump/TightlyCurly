using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IMenu : IModel
    {
        string Name { get; set; }
        IEnumerable<IContentItem> ContentItems { get; set; }
        IEnumerable<IMenuItem> MenuItems { get; set; }
        IEnumerable<IMenuText> MenuTexts { get; set; } 
    }
}
