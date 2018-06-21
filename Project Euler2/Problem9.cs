using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,

//a2 + b2 = c2
//For example, 32 + 42 = 9 + 16 = 25 = 52.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

namespace Project_Euler2
{
    class Problem9
    {
        public static int Workout()
        {
            int a;
            int b;
            int c;
            int answer = 0;
            bool found = false;
            for (c = 334; c < 998; c++)
            {
                int csq = c * c;
                a = Math.Min(c - 1, 1000 - c - 1);
                b = 1000 - a - c;
                while (a>=b)
                {
                    if (csq == a*a + b*b)
                    {
                        answer = a * b * c;
                        found = true;
                        break;
                    }
                    a--;
                    b++;
                }
                if (found)
                {
                    break;
                }
                
            }
            return answer;
        }
    }
}
