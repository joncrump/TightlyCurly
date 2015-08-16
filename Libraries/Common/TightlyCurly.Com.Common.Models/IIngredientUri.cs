using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IIngredientUri : IModel
    {
        Guid IngredientId { get; set; }
        Uri Uri { get; set; }
        string Comment { get; set; }
        string Description { get; set; }
    }
}
