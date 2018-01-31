using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10 001st prime number?

namespace Project_Euler2
{
    class Problem7
    {
        public static int Workout()
        {
            int primeSize = 0;
            int currNum = 2;
            HashSet<int> primes = new HashSet<int>();
            bool isPrime = true;
            int currPrime = 2;

            while (primeSize < 10001)
            {
                
                isPrime = true;
                foreach (int prime in primes)
                {
                    if (currNum % prime == 0)
                    {
                        isPrime = false;
                        break;                     
                    }
                }

                if (isPrime)
                {
                    primes.Add(currNum);
                    primeSize++;
                }

                currPrime = currNum;
                currNum++;

            }

            return currPrime;
            
        }
        
    }
}
