using System;
using System.Collections.Generic;
using System.Linq;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.Framework.Extensions;

namespace TightlyCurly.Com.Admin.Web
{
    public partial class IngredientsAdmin //: PageBase<IngredientsAdminPresenter, IIngredientsAdminView>, IIngredientsAdminView
    {
        public IEnumerable<Ingredient> Ingredients
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                DataBindIngredients(value);
            }
        }

        public Ingredient SelectedIngredient
        {
            get
            {
                return GetIngredient();
            }
            set
            {
                if (value == null)
                {
                    ResetValues();
                    return;
                }

                DataBindIngredient(value);
            }
        }

        public Uri SelectedUri
        {
            get
            {
                return !String.IsNullOrEmpty(IngredientUri.Text) ? new Uri(IngredientUri.Text) : null;
            }
            set 
            {
                IngredientUri.Text = value != null ? value.ToString() : null;
            }
        }

        protected void EditIngredient_Clicked(object sender, EventArgs e)
        {
            //if (IngredientNames.SelectedIndex >= 0)
            //{
            //    Presenter.GetIngredientById(Int32.Parse(IngredientNames.SelectedValue));
            //}
        }

        protected void RemoveIngredient_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //if (IngredientNames.SelectedIndex >= 0)
            //{
            //    string title = IngredientNames.SelectedItem.Text;
            //    var ingredient = new Ingredient { Id = Int32.Parse(IngredientNames.SelectedValue), Title = title };//Ingredient.GetIngredient(i => i.Id == Int32.Parse(IngredientNames.SelectedValue));

            //    Presenter.DeleteIngredient(ingredient);

            //    DataBindValues();
            //    MessageBox.Show(String.Format("{0} has been removed from the dictionary.", title));
            //}
        }

        protected void Save_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //var ingredient = SelectedIngredient;

            //Presenter.SaveIngredient(ingredient);
            //DataBindValues();

            //MessageBox.Show(String.Format("{0} has been {1}.", ingredient.Title, "saved"));
        }

        private void ResetValues()
        {
            Id.Value = null;
            Title.Text = null;
            Alias.Text = null;
            Description.Text = null;
            IngredientRating.SelectedIndex = -1;
            IngredientNames.SelectedIndex = -1;
            References.Reset();
            Links.Reset();
            SeeAlso.Reset();
        }

        private Ingredient GetIngredient()
        {
            throw new NotImplementedException();
            //var Id = 0;
            //var enteredDate = DateTime.MinValue;
            //var updatedDate = DateTime.MinValue;

            //Int32.TryParse(Id.Value, out Id);
            //DateTime.TryParse(EnteredDate.Value, out enteredDate);
            //DateTime.TryParse(UpdatedDate.Value, out updatedDate);

            //return new Ingredient
            //                     {
            //                         Id = Id,
            //                         Title = Title.Text,
            //                         Aliases = Alias.Text,
            //                         Descriptions = Description.Text,
            //                         IngredientRating =
            //                             (IngredientRating.SelectedIndex >= 0
            //                                  ? (int?) IngredientRating.SelectedIndex
            //                                  : null),
            //                         InternalLinks = GetInternalLinks(),
            //                         ExternalLinks = GetExternalLinks(),
            //                         EnteredDate = enteredDate,
            //                         UpdatedDate = updatedDate
            //                     };
        }

        protected void NewIngredient_Clicked(object sender, EventArgs e)
        {
            ResetValues();
        }

        private string GetInternalLinks()
        {
            var internalLinks = SeeAlso.Values;

            return internalLinks.IsNullOrEmpty() ? null : String.Join(",", internalLinks.ToArray());
        }

        private string GetExternalLinks()
        {
            var externalLinks = new List<string>();
            var references = GetReferences();
            var allExternalLinks = GetAllExternalLinks();

            if (!references.IsNullOrEmpty())
            {
                externalLinks.AddRange(GetReferences());
            }

            if (!allExternalLinks.IsNullOrEmpty())
            {
                externalLinks.AddRange(allExternalLinks);
            }

            return !externalLinks.Any() ? null : String.Join(",", externalLinks.ToArray());
        }

        private IEnumerable<string> GetReferences()
        {
            var references = References.Values.ToArray();

            if (!references.IsNullOrEmpty())
            {
                for (var index = 0; index < references.Count(); index++)
                {
                    var reference = references[index];
                    reference = "#" + reference;
                    references[index] = reference;
                }
            }

            return references;
        }

        private IEnumerable<string> GetAllExternalLinks()
        {
            return Links.Values;
        }

        private void DataBindValues()
        {
            //Presenter.GetAllIngredients();
        }

        private void DataBindIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
            //if (ingredient == null)
            //{
            //    return;
            //}

            //Id.Value = ingredient.Id.ToString();
            //Title.Text = ingredient.Title;
            //Alias.Text = ingredient.Aliases;
            //Description.Text = ingredient.Descriptions;
            //IngredientRating.SelectedIndex = (ingredient.IngredientRating.HasValue ? ingredient.IngredientRating.Value : 0);
            //DataBindReferences(ingredient);
            //DataBindLinks(ingredient);
            //DataBindInternalLinks(ingredient);
            //EnteredDate.Value = ingredient.EnteredDate.ToString();
            //UpdatedDate.Value = ingredient.UpdatedDate.ToString();
        }

        private void DataBindReferences(Ingredient ingredient)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(ingredient.ExternalLinks))
            //{
            //    return;
            //}

            //var references = ingredient.ExternalLinks.Split(',')
            //    .Where(reference => !String.IsNullOrEmpty(reference) && reference.StartsWith("#"))
            //    .Select(reference => reference.Replace("#", String.Empty));

            //References.Values = references;
        }

        private void DataBindLinks(Ingredient ingredient)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(ingredient.ExternalLinks))
            //{
            //    return;
            //}

            //var links = ingredient.ExternalLinks.Split(',')
            //    .Where(link => !String.IsNullOrEmpty(link) && !link.StartsWith("#"));

            //Links.Values = links;
        }

        private void DataBindInternalLinks(Ingredient ingredient)
        {
            throw new NotImplementedException();
            //if (String.IsNullOrEmpty(ingredient.InternalLinks))
            //{
            //    return;
            //}

            //var links = ingredient.InternalLinks.Split(',')
            //    .Where(link => !String.IsNullOrEmpty(link));

            //SeeAlso.Values = links;
        }

        private void DataBindIngredients(IEnumerable<Ingredient> ingredients)
        {
            throw new NotImplementedException();
            //IngredientNames.DataValueField = "Id";
            //IngredientNames.DataTextField = "Title";
            //IngredientNames.DataSource = ingredients.IsNullOrEmpty() ? Enumerable.Empty<Ingredient>() :
            //    ingredients.OrderBy(i => i.Title);
            
            //IngredientNames.DataBind();
        }
    }
}
