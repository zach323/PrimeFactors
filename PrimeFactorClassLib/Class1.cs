using System;

namespace PrimeFactorClassLib
{
    public class PrimeFactor
    {
        public string PrimeCalc(int num)
        {
            string primes = string.Empty;
            int prime = 0;
            int result = num;
            for (int i = 2; i < num; i++)
            {
                if (result % i == 0) 
                {
                    prime = i;
                    while (result % prime == 0)
                    {
                        if (result != prime)
                        {
                            primes += $"{prime} X ";
                        }
                        else
                        {
                           primes += $"{prime}";
                        }
                        
                        result /= prime;
                        
                    }
                    
                }
                
            }
            return primes;
         
        }
    }
}
