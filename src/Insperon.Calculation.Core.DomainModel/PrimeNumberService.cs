using Insperon.Core.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Insperon.Calculation.Core.DomainModel
{
    public class PrimeNumberService : IPrimeNumberService
    {
        public PrimeNumberService(IPrimeNumberRepository primeNumberrepository)
        {
            this.primeNumberRepository = primeNumberrepository;
        }

        public PrimeNumber Create(int index, long primeValue)
        {
            var primeNumber = new PrimeNumber(index, primeValue);

            using (var transactionScope = new TransactionScope())
            {
                this.primeNumberRepository.Add(primeNumber);
                transactionScope.Complete();
            }

            return primeNumber;
        }


        public PrimeNumber Update(PrimeNumber primeNumber, int index, long primeValue)
        {
            if (primeNumber == null)
            {
                throw new CalculationDomainModelException("primeNumber cannot be null");
            }

            primeNumber.Index = index;
            primeNumber.PrimeValue = primeValue;

            using (var transactionScope = new TransactionScope())
            {
                this.primeNumberRepository.Update(primeNumber);
                transactionScope.Complete();
            }

            return primeNumber;
        }

        private readonly IPrimeNumberRepository primeNumberRepository;
    }
}
