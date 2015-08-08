using System;
using System.Collections.Generic;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Models;

namespace TightlyCurly.Com.Repositories.Models
{
    public class PersonRelationshipDataModel : ValueFactoryModelBase, IPersonRelationship
    {
        public Guid Id { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid PrimaryId { get; set; }
        public IPerson Primary { get; set; }
        public IEnumerable<IPerson> Secondaries { get; set; }
    }
}
