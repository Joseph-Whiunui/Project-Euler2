using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project_Euler2
{
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //Find the sum of all the primes below two million.
    //1:13

    class Problem10
    {
        public static long Workout()
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            bool isPrime = true;
            long sum = 0;

            for (int i = 3; i < 2000000; i+=2)
            {
                isPrime = true;
                int maxFactor = Convert.ToInt32(Math.Sqrt(i));
                foreach(int prime in primes)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    if (prime > maxFactor)
                    {
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                    sum += i;
                }
            }

            return sum;
        }
    }
}
