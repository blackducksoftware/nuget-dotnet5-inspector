using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Synopsys.Integration.Nuget.Dotnet3.Configuration
{
    class AppConfigArgAttribute : Attribute
    {
        public string Key;
        public AppConfigArgAttribute(string key)
        {
            Key = key;
        }
    }
}
