using System;
using System.Web;
using System.Web.Caching;
using TightlyCurly.Com.Framework.Web.Caching;

namespace TightlyCurly.Com.Admin.Web
{
    public class PageContext
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public string UserAgent { get; set; }

        public static PageContext Current
        {
            get
            {
                HttpContext context = HttpContext.Current;

                if (!CacheHelper.IsInCache(context.Session.SessionID + "PageContext"))
                {
                    CacheHelper.InsertCache(context.Session.SessionID + "PageContext",
                        NewObject());
                }

                return (PageContext)CacheHelper.RetrieveFromCache(context.Session.SessionID + "PageContext");
            }
        }

        #endregion

        #region Methods

        public static PageContext NewObject()
        {
            return new PageContext() { UserAgent = HttpContext.Current.Request.UserAgent };
        }

        #endregion
    }
}
