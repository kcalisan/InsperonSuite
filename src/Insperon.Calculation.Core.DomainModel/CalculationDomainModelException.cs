using Insperon.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Calculation.Core.DomainModel
{
    public class CalculationDomainModelException : InsperonCoreException
    {
        public CalculationDomainModelException()
            : base()
        {
        }

        public CalculationDomainModelException(string message)
            : base(message)
        {
        }

        public CalculationDomainModelException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
