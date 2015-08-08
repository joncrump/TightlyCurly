using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class PatentDataModel : IPatent
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string PatentNumber { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPending { get; set; }
        public IEnumerable<IPatentAuthor> Authors { get; set; }
        public IEnumerable<ICompany> Owners { get; set; }
        public IEnumerable<ICountry> Countries { get; set; }
    }
}
