using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IIngredient : IModel
    {
        string Title { get; set; }
        string Description { get; set; }

        IEnumerable<IIngredientCategory> IngredientCategories { get; set; }
        IEnumerable<IIngredientAlias> Aliases { get; set; }
        IEnumerable<Uri> Links { get; set; }
        IEnumerable<IIngredientRating> IngredientRatings { get; set; }
        IEnumerable<IIngredientNote> Notes { get; set; }
        IEnumerable<IIngredientComment> Comments { get; set; }
        IEnumerable<IContentArticle> ContentArticles { get; set; }
    }
}
