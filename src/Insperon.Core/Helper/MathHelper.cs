using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Insperon.Core.Helper
{
    public static class MathHelper
    {
       public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));
            int i = 6; 
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }

            return true;
        }

    }
}
