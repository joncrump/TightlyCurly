using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Model;
using TightlyCurly.Com.Framework.Extensions;
using TightlyCurly.Com.Web.MasterPages;
using TightlyCurly.Com.Framework.Web.Utilities;
using Ingredient = TightlyCurly.Com.Web.Services.Ingredient;
using UIConstants = TightlyCurly.Com.Web.Common.Constants;

namespace TightlyCurly.Com.Web.UserControls
{
    public partial class IngredientsControl //: UserControlBase<IngredientsPresenter, IIngredientsView>, IIngredientsView
    {
        public CategoryControl CategoryControl 
        {
            get
            {
                return categories;
            }
        }

        private void InitializeEvents()
        {
            categories.ItemSelected += ItemSelected;
        }

        private void ItemSelected(object sender, ItemSelectedEventArgs e)
        {
            //DataBindView(Presenter.GetIngredients(i => i.Title.StartsWith(e.SelectedItem)));
        }

        private Func<Ingredient, bool> ParseRouteData()
        {
            throw new NotImplementedException();
            //var title = GetIngredientTitle(Page.RouteData.Values["ingredientName"].ToString());
            //Func<Ingredient, bool> queryDelegate = i => i.Title == title;

            //return queryDelegate;
        }

        private string GetIngredientTitle(string ingredientName)
        {
            throw new NotImplementedException();
            //var urlEntryDataProvider = Container.Resolve<IUrlEntryDataProvider>();
            //var ingredientDataProvider = Container.Resolve<IIngredientDataProvider>();
            //var urlEntry = urlEntryDataProvider.GetUrlEntryByKey(ingredientName);
            
            //if (urlEntry == null)
            //{
            //    return null;
            //}

            //var ingredient = ingredientDataProvider.GetIngredientById(urlEntry.ObjectId);

            //return ingredient.Title;
        }

        private Func<Ingredient, bool> ParseQueryString(NameValueCollection queryStrings)
        {
            if (!queryStrings.HasKeys())
            {
                return null;
            }

            Func<Ingredient, bool> queryDelegate = null;
            var Id = 0;

            if (queryStrings[UIConstants.IngredientsConstants.IngredientsIdQuery] != null 
                && Int32.TryParse(queryStrings[UIConstants.IngredientsConstants.IngredientsIdQuery], out Id))
            {
                queryDelegate = i => i.Id == Id;
            }
            else if (queryStrings[UIConstants.IngredientsConstants.IngredientsNameQuery] != null
                && !String.IsNullOrEmpty(queryStrings[UIConstants.IngredientsConstants.IngredientsNameQuery]))
            {
                queryDelegate = i => i.Title
                    .ToLower()
                    .StartsWith(TextEncoder.SafeEncode(queryStrings[UIConstants.IngredientsConstants.IngredientsNameQuery].ToLower()));
            }

            return queryDelegate;
        }

        private void DataBindView()
        {
            //Func<Ingredient, bool> queryDelegate = null;

            //if (Page.RouteData.Values.ContainsKey("ingredientName") &&
            //    !String.IsNullOrEmpty(Page.RouteData.Values["ingredientName"].ToString()))
            //{
            //    queryDelegate = ParseRouteData();
            //}
            //else
            //{
            //    queryDelegate = ParseQueryString(Request.QueryString);
            //}

            //if (queryDelegate != null)
            //{
            //    DataBindView(Presenter.GetIngredients(queryDelegate));
            //}
        }

        private void DataBindView(IEnumerable<Services.Ingredient> ingredients)
        {
            grdIngredients.DataSource = ingredients.IsNullOrEmpty() ? Enumerable.Empty<Ingredient>() : ingredients.OrderBy(i => i.Title, new IngredientComparer());
            grdIngredients.DataBind();

            if (ingredients != null && ingredients.Any())
            {
                SetTitle(ingredients);
            }
        }

        private void SetTitle(IEnumerable<Ingredient> ingredients)
        {
            //var masterPage = this.Page.Master as Master;
            //var title = String.Empty;
            //var ingredientsPage = this.Page as Ingredients;
            
            //if (ingredients.Count() == 1)
            //{
            //    title = ingredients.First().Title;
                
            //    if (masterPage != null)
            //    {
            //        masterPage.PageTitle = title;
            //    }
            //}
            //else
            //{
            //    title = ingredients.First().Title.Substring(0, 1);

            //    if (masterPage != null)
            //    {
            //        masterPage.PageTitle = String.Format(Resources.TightlyCurly.Com.Web.ingredientsStartingWith,
            //            String.Format(Resources.TightlyCurly.Com.Web.formattedSpan, title));
            //    }

            //    title = String.Format(Resources.TightlyCurly.Com.Web.ingredientsStartingWith, title);
            //}

            //Page.Title = title;

            //if (ingredientsPage != null)
            //{
            //    ingredientsPage.Preamble.Visible = String.IsNullOrEmpty(title);
            //}
        }

        protected void grdIngredients_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            var ingredient = e.Row.DataItem as Ingredient;

            if (ingredient == null)
            {
                return;
            }

            FormatTitle(ingredient, (Label)e.Row.FindControl("title"));
            FormatAlias(ingredient, (Label)e.Row.FindControl("alias"));
            FormatRating(ingredient, (Label)e.Row.FindControl("ingredientRating"));
            FormatReferences(ingredient, (Label)e.Row.FindControl("relatedLinksLabel"), (Literal)e.Row.FindControl("relatedLinks"));
            FormatExternalLinks(ingredient, (Label)e.Row.FindControl("externalLinksLabel"), (Literal)e.Row.FindControl("externalLinks"));
        }

        private void FormatTitle(Ingredient ingredient, Label label)
        {
            label.Text = ingredient.Title;
        }

        private void FormatAlias(Ingredient ingredient, Label label)
        {
            if (String.IsNullOrEmpty(ingredient.Alias))
            {
                return;
            }

            label.Visible = true;
            label.Text = String.Format(Resources.TightlyCurly.Com.Web.alsoKnownAs, DataBinder.Eval(ingredient, "Alias"));
        }

        private void FormatRating(Ingredient ingredient, Label label)
        {
            throw new NotImplementedException();
            //if (ingredient.IngredientRating.HasValue)
            //{
            //    switch (ingredient.IngredientRating)
            //    {
            //        case IngredientRating.Avoid:
            //            label.Text = UIConstants.IngredientsConstants.AvoidText;
            //            label.CssClass = UIConstants.IngredientsConstants.AvoidStyle;
            //            break;
            //        case IngredientRating.Caution:
            //            label.Text = UIConstants.IngredientsConstants.CautionText;
            //            label.CssClass = UIConstants.IngredientsConstants.CautionStyle;
            //            break;
            //        case IngredientRating.Good:
            //            label.Text = UIConstants.IngredientsConstants.GoodText;
            //            label.CssClass = UIConstants.IngredientsConstants.GoodStyle;
            //            break;
            //        default:
            //            label.Text = UIConstants.IngredientsConstants.AcceptableText;
            //            label.CssClass = UIConstants.IngredientsConstants.AcceptableStyle;
            //            break;
            //    }
            //}
            //else
            //{
            //    label.Text = UIConstants.IngredientsConstants.AcceptableText;
            //    label.CssClass = UIConstants.IngredientsConstants.AcceptableStyle;
            //}
        }

        private void FormatReferences(Ingredient ingredient, Control related, Literal references)
        {
            if (String.IsNullOrEmpty(ingredient.InternalLinks))
            {
                return;
            }

            related.Visible = true;
            references.Visible = true;
            var internalLinks = ingredient.InternalLinks.Split(UIConstants.IngredientsConstants.Delimiter);

            var linkBuilder = new StringBuilder();

            foreach (var internalLink in internalLinks)
            {
                linkBuilder.Append("<a href=\"" + UIConstants.IngredientsConstants.LinkUrl + "?" + UIConstants.IngredientsConstants.IngredientsNameQuery + "=" + internalLink + "\">" + internalLink + "</a> ");
            }

            references.Text += linkBuilder.ToString();
            references.Text += "<br />";
        }

        private void FormatExternalLinks(Services.Ingredient ingredient, Label externalLinksText, Literal externalLinks)
        {
            if (String.IsNullOrEmpty(ingredient.ExternalLinks))
            {
                return;
            }

            externalLinksText.Visible = true;
            externalLinks.Visible = true;

            var links = ingredient.ExternalLinks.Split(UIConstants.IngredientsConstants.Delimiter);

            var linkBuilder = new StringBuilder();

            foreach (var link in links)
            {
                if (String.IsNullOrEmpty(link))
                {
                    continue;
                }

                var key = String.Empty;
                var externalLink = link;

                if (externalLink.StartsWith(UIConstants.Anchor))
                {
                    key = externalLink.Replace(UIConstants.Anchor, String.Empty);
                    externalLink = UIConstants.IngredientsConstants.LinkUrl + externalLink;
                }

                linkBuilder.Append("<a href=\"" + externalLink + "\">" + (key == String.Empty ? externalLink : key) + "</a> ");
            }

            externalLinks.Text += linkBuilder.ToString();
            externalLinks.Text += "<br />";
        }
    }
}