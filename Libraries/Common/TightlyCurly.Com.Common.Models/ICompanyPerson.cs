using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface ICompanyPerson : IPerson
    {
        IEnumerable<ICompanyPosition> Positions { get; set; }
    }
}
