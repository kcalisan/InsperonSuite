using Insperon.Data.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Calculation.Core.DomainModel
{
    public interface IPrimeNumberIndexSearchService : IService
    {
        long GetPrimeNumberByIndex(int index);
    }
}
