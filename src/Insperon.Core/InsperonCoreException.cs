using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Core
{
    public class InsperonCoreException : Exception
    {
        public InsperonCoreException()
            : base()
        {
        }

        public InsperonCoreException(string message)
            : base(message)
        {
        }

        public InsperonCoreException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
