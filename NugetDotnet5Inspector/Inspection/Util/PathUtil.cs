using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Com.Synopsys.Integration.Nuget.Dotnet3.Inspection.Util
{
    static class PathUtil
    {
        public static string Combine(List<string> pathSegments)
        {
            return Combine(pathSegments.ToArray());
        }

        public static string Combine(params string[] pathSegments)
        {
            String path = Path.Combine(pathSegments);
            return path.Replace("\\", "/");
        }

        public static string Sanitize(String path)
        {
            return path.Replace("\\", "/");
        }
    }
}
