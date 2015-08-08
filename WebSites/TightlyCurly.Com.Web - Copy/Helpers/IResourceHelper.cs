using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TightlyCurly.Com.Web.Helpers
{
    public interface IResourceHelper
    {
        string UnderConstructionContent { get; }
        string UnderConstructionDescription { get; }
        string UnderConstructionTitle { get; }
    }
}
