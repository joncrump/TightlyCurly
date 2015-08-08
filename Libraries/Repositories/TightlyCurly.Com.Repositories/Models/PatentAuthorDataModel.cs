using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class PatentAuthorDataModel : ValueFactoryModelBase, IPatentAuthor
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Honorific { get; set; }
        public string Suffix { get; set; }
        public ILocale PreferredLocale { get; set; }
        public IEnumerable<ISocialMediaInfo> SocialMediaInfo { get; set; }
        public IEnumerable<IContactInfo> ContactInfo { get; set; }
        public IEnumerable<IPersonRelationship> Relationships { get; set; }
        public IEnumerable<IPatent> Patents { get; set; }
    }
}
