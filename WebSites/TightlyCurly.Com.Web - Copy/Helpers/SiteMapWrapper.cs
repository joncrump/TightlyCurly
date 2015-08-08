using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TightlyCurly.Com.Web.Helpers
{
    public class SiteMapWrapper : ISiteMapWrapper
    {
        public string PageTitle
        {
            get 
            {
                if (SiteMap.CurrentNode != null && !String.IsNullOrEmpty(SiteMap.CurrentNode.Description))
                {
                    return SiteMap.CurrentNode.Description;
                }

                return String.Empty;
            }
            set
            {
                throw new NotImplementedException();
            }

        }
    }
}
