using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TightlyCurly.Com.Web.Helpers
{
    public class ResourceHelper : IResourceHelper
    {
        public string UnderConstructionContent
        {
            get 
            {
                return Resources.TightlyCurly.Com.Web.underConstructionContent;
            }
        }

        public string UnderConstructionDescription
        {
            get
            {
                return Resources.TightlyCurly.Com.Web.underConstructionDescription;
            }
        }

        public string UnderConstructionTitle
        {
            get
            {
                return Resources.TightlyCurly.Com.Web.underConstructionTitle;
            }
        }
    }
}
