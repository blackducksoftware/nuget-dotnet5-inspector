using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Synopsys.Integration.Nuget.Dotnet3.Inspection.Exceptions
{
    [Serializable]
    class BlackDuckInspectorException : Exception
    {
        public BlackDuckInspectorException() : base()
        {
        }

        public BlackDuckInspectorException(string message) : base(message)
        {
        }

        public BlackDuckInspectorException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}