using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Synopsys.Integration.Nuget.Dotnet3.Configuration
{
    public static class AppConfigKeys
    {
        public const string TargetPath = "target_path";
        public const string PackagesRepoUrl = "packages_repo_url";
        public const string NugetConfigPath = "nuget_config_path";
        public const string OutputDirectory = "output_directory";
        public const string ExcludedModules = "excluded_modules";
        public const string IncludedModules = "included_modules";
        public const string IgnoreFailures = "ignore_failure";
    }
}
