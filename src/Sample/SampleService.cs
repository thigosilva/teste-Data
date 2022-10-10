using System;

namespace Sample
{
    public class SampleService
    {
        
        public decimal Subtract(decimal total = 0, params decimal[] values)
        {
            throw new NotImplementedException();
        }

        
        public decimal Sum(decimal total = 0, params decimal[] values)
        {
            var result = total;

            foreach (var item in values)
            {
                result += item;
            }

            return result;
        }

        public bool IsEven(int candidate)
        {
            if (candidate % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsOdd(int candidate)
        {
            if (candidate % 2 != 0)
            {
                return true;
            }
            return false;
        }

        #region Verifica se o número é primo ou não
        public bool IsPrime(int candidate)
        {

            if (candidate < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor < Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
