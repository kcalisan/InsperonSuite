using Insperon.Calculation.Core.DomainModel;
using Insperon.Data.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Calculation.Core.Persistence
{
    public class PrimeNumberRepository : RepositoryBase<PrimeNumber, int>, IPrimeNumberRepository
    {
        public PrimeNumberRepository(InsperonDbContext insperonDbContext)
            : base(insperonDbContext)
        {

        }
    }
}
