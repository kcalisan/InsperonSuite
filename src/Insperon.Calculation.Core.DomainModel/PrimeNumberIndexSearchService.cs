using Insperon.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Insperon.Calculation.Core.DomainModel
{
    public class PrimeNumberIndexSearchService : IPrimeNumberIndexSearchService
    {
        public PrimeNumberIndexSearchService(
            IPrimeNumberRepository primeNumberRepository)
        {
            this.primeNumberRepository = primeNumberRepository;
        }
        public long GetPrimeNumberByIndex(int index)
        {
            var primeNumberList = this.primeNumberRepository.GetAll().ToList();
            var primeNumber = primeNumberList.Where(x => x.Index == index).FirstOrDefault();
            IList<PrimeNumber> calculatedPrimeNumbers = new List<PrimeNumber>();
            if (primeNumber != null)
            {
                return primeNumber.PrimeValue;
            }

            long primeValue = 0;
            int indexCount = 0;

            for (long number = 1; number < long.MaxValue; number++)
            {
                if (MathHelper.IsPrime(number))
                {
                    indexCount++;
                    if (!primeNumberList.Any(x => x.Index == indexCount && x.PrimeValue == number))
                    {
                        calculatedPrimeNumbers.Add(new PrimeNumber(indexCount, number));
                    }

                    if (index == indexCount)
                    {
                        primeValue = number;
                        break;
                    }
                }
            }
            if (calculatedPrimeNumbers != null)
            {
                this.primeNumberRepository.AddRange(calculatedPrimeNumbers);
            }

            return primeValue;
        }

        private readonly IPrimeNumberRepository primeNumberRepository;
    }
}
