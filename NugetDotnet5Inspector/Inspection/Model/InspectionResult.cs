using Com.Synopsys.Integration.Nuget.Dotnet3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Synopsys.Integration.Nuget.Dotnet3.Inspection.Model
{
    class InspectionResult
    {
        public enum ResultStatus
        {
            Success,
            Error
        }

        public string ResultName;
        public string OutputDirectory;
        public ResultStatus Status;
        public List<Container> Containers = new List<Container>();
        public Exception Exception;

    }
}
