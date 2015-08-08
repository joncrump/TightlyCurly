using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TightlyCurly.Com.Admin.Web
{
    public static class Constants
    {
        public const string ApplicationName = "ApplicationName";

        public static class ControlConstants
        {
            public const string MessageBox = "MessageBoxControl";
        }

        public static class Defaults
        {
            public const string DefaultApplicationName = "/";
            public const string DefaultHashingAlgorithm = "SHA1";
        }

        public static class DatabaseConstants
        {
            public const string AdminConnection = "AdminConnection";
            public const string TightlyCurly = "TightlyCurly";
        }
    }
}
