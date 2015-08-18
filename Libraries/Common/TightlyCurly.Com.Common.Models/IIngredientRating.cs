using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models 
{
    public interface IIngredientRating : IModel
    {
        Guid RatingTypeId { get; set; }
        IRatingType RatingType { get; set; }
        Guid IngredientId { get; set; }
        IEnumerable<IIngredientRatingText> Texts { get; set; }
    }
}
