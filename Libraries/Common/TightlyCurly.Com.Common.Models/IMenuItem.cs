using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IMenuItem : IModel
    {
        Guid? ParentId { get; set; }
        IMenuItem Parent { get; set; }
        IEnumerable<IMenuItemText> MenuItemTexts { get; set; }
        int? Order { get; set; }
        IEnumerable<IMenuItem> Children { get; set; }
        IEnumerable<IMenu> Menus { get; set; }
        Uri Uri { get; set; }
    }
}