using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class ProductVariantDataModel : ValueFactoryModelBase, IProductVariant
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IProduct Product { get; set; }
        public string Name { get; set; }
        public IEnumerable<IManufacturerInfo> Manufacturers { get; set; }
        public IEnumerable<IBrand> Brands { get; set; }
        public IEnumerable<IProductVariantSkuInfo> Skus { get; set; }
        public IEnumerable<IMarket> Markets { get; set; }
        public IEnumerable<IIngredientInfo> Ingredients { get; set; }
        public IEnumerable<IProductRevisionHistory> RevisionHistory { get; set; }
        public IEnumerable<ILocation> LocationsSoldAt { get; set; }
        public IEnumerable<IProductCategory> ProductCategories { get; set; }
        public IEnumerable<IProductVariantReview> ProductReviews { get; set; }
        public IEnumerable<IProductSafetyInfo> ProductSafetyInfos { get; set; }
        public IEnumerable<IProductType> ProductTypes { get; set; }
        public IEnumerable<IImageUri> ProductVariantImageUris { get; set; }
        public IEnumerable<ICopyright> Copyrights { get; set; }
        public IEnumerable<ITrademark> Trademarks { get; set; }
        public IEnumerable<IPatent> Patents { get; set; }
        public IEnumerable<IProductVariantNote> Notes { get; set; }
        public IEnumerable<IProductVariantDescription> Descriptions { get; set; }
        public IEnumerable<IProductVariantMetadata> Metadata { get; set; }
    }
}
