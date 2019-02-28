using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Core.Logging
{
    public interface IAppLogger<T>
    {
        void LogError(string message, params object[] args);
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);

    }
}
