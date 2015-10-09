using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightlyCurly.Com.Common.Models
{
    public interface IProductVariantImageUri : IModel
    {
        Guid ProductVariantId { get; set; }
        string Uri { get; set; }
        string Description { get; set; }
        string AltText { get; set; }
        bool? IsPrimary { get; set; }
        int? Order { get; set; }
        bool? IsActive { get; set; }

        IProductVariant ProductVariant { get; set; }
    }
}
