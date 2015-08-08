using System;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class PhoneNumberDataModel : IPhoneNumber
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Extension { get; set; }
    }
}
