using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductRevisionHistoryEntry : IModel
    {
        Guid ProductRevisionHistoryId { get; set; }
        Guid ProductVariantId { get; set; }
        string OldIngredients { get; set; }
        string NewIngredients { get; set; }
        string Comments { get; set; }
        string Notes { get; set; }

        IProductVariant ProductVariant { get; set; }
    }
}
