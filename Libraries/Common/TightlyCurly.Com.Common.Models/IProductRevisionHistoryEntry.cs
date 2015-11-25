using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductRevisionHistoryEntry : IModel
    {
        Guid ProductRevisionHistoryId { get; set; }
        string OldIngredients { get; set; }
        string NewIngredients { get; set; }
        string Comments { get; set; }
        string Notes { get; set; }
        IProductRevisionHistory ProductRevisionHistory { get; set; }
    }
}
