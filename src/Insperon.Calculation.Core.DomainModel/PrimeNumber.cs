using Insperon.Data.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Calculation.Core.DomainModel
{
    public interface IPrimeNumberRepository: ICruRepository<PrimeNumber, int>
    {

    }

    public class PrimeNumber : EntityBase<int>
    {
        protected PrimeNumber()
        {

        }
        public PrimeNumber(int index, long primeValue)
        {
            Index = index;
            PrimeValue = primeValue;
        }

        public virtual int Index { get; protected internal set; }
        public virtual long PrimeValue { get; protected internal set; }
    }
}
