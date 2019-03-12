using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2) 
                return false;
            
            if (candidate < 4)
                return true; 

            if (candidate %2 == 0 || candidate %3 == 0) 
                return false;

            for (int i=5; i*i<= candidate; i=i+6)
                if (candidate % i == 0 || candidate % (i+2) == 0)
                    return false;

            return true;
        }
    }
}
