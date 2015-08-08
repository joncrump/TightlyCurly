//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 7/12/2012 5:41:01 PM
namespace TightlyCurly.Com.Web.Services
{
    
    /// <summary>
    /// There are no comments for DataEntitiesDataContext in the schema.
    /// </summary>
    public partial class DataEntitiesDataContext : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new DataEntitiesDataContext object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public DataEntitiesDataContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Alligoshee.Hair.Business", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("TightlyCurly.Com.Web.Services", typeName.Substring(24)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("TightlyCurly.Com.Web.Services", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Alligoshee.Hair.Business.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Ingredients in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Ingredient> Ingredients
        {
            get
            {
                if ((this._Ingredients == null))
                {
                    this._Ingredients = base.CreateQuery<Ingredient>("Ingredients");
                }
                return this._Ingredients;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Ingredient> _Ingredients;
        /// <summary>
        /// There are no comments for Ingredients in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToIngredients(Ingredient ingredient)
        {
            base.AddObject("Ingredients", ingredient);
        }
    }
    /// <summary>
    /// There are no comments for Alligoshee.Hair.Business.Ingredient in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Ingredient
    {
        /// <summary>
        /// Create a new Ingredient object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="localeId">Initial value of LocaleId.</param>
        /// <param name="updatedDate">Initial value of UpdatedDate.</param>
        /// <param name="enteredDate">Initial value of EnteredDate.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Ingredient CreateIngredient(int ID, int localeId, global::System.DateTime updatedDate, global::System.DateTime enteredDate)
        {
            Ingredient ingredient = new Ingredient();
            ingredient.Id = ID;
            ingredient.LocaleId = localeId;
            ingredient.UpdatedDate = updatedDate;
            ingredient.EnteredDate = enteredDate;
            return ingredient;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Alias in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Alias
        {
            get
            {
                return this._Alias;
            }
            set
            {
                this.OnAliasChanging(value);
                this._Alias = value;
                this.OnAliasChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Alias;
        partial void OnAliasChanging(string value);
        partial void OnAliasChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property InternalLinks in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string InternalLinks
        {
            get
            {
                return this._InternalLinks;
            }
            set
            {
                this.OnInternalLinksChanging(value);
                this._InternalLinks = value;
                this.OnInternalLinksChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _InternalLinks;
        partial void OnInternalLinksChanging(string value);
        partial void OnInternalLinksChanged();
        /// <summary>
        /// There are no comments for Property ExternalLinks in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ExternalLinks
        {
            get
            {
                return this._ExternalLinks;
            }
            set
            {
                this.OnExternalLinksChanging(value);
                this._ExternalLinks = value;
                this.OnExternalLinksChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ExternalLinks;
        partial void OnExternalLinksChanging(string value);
        partial void OnExternalLinksChanged();
        /// <summary>
        /// There are no comments for Property IngredientRating in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> IngredientRating
        {
            get
            {
                return this._IngredientRating;
            }
            set
            {
                this.OnIngredientRatingChanging(value);
                this._IngredientRating = value;
                this.OnIngredientRatingChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _IngredientRating;
        partial void OnIngredientRatingChanging(global::System.Nullable<int> value);
        partial void OnIngredientRatingChanged();
        /// <summary>
        /// There are no comments for Property LocaleId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int LocaleId
        {
            get
            {
                return this._LocaleId;
            }
            set
            {
                this.OnLocaleIdChanging(value);
                this._LocaleId = value;
                this.OnLocaleIdChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _LocaleId;
        partial void OnLocaleIdChanging(int value);
        partial void OnLocaleIdChanged();
        /// <summary>
        /// There are no comments for Property UpdatedDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime UpdatedDate
        {
            get
            {
                return this._UpdatedDate;
            }
            set
            {
                this.OnUpdatedDateChanging(value);
                this._UpdatedDate = value;
                this.OnUpdatedDateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _UpdatedDate;
        partial void OnUpdatedDateChanging(global::System.DateTime value);
        partial void OnUpdatedDateChanged();
        /// <summary>
        /// There are no comments for Property EnteredDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime EnteredDate
        {
            get
            {
                return this._EnteredDate;
            }
            set
            {
                this.OnEnteredDateChanging(value);
                this._EnteredDate = value;
                this.OnEnteredDateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _EnteredDate;
        partial void OnEnteredDateChanging(global::System.DateTime value);
        partial void OnEnteredDateChanged();
    }
}
