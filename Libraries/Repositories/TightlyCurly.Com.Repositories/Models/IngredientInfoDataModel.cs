using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class IngredientInfoDataModel : IIngredientInfo
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public IIngredient Ingredient { get; set; }
        public int? Order { get; set; }
        public bool? IsActive { get; set; }
    }
}
