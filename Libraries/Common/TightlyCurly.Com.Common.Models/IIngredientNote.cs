using System;

namespace TightlyCurly.Com.Common.Models
{
    public interface IIngredientNote : IModel
    {
        Guid IngredientId { get; set; }
        string Note { get; set; }
        Guid EnteredByUserId { get; set; }
        IUser EnteredBy { get; set; }
    }
}
