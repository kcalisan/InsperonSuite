using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Calculation.Core.DomainModel
{
    public interface IPrimeNumberService
    {
        PrimeNumber Create(int index, long primeValue);
        PrimeNumber Update(PrimeNumber primeNumber, int index, long primeValue);
    }
}
