using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler2
{
    class Solver
    {
        static void Main(string[] args)
        {
            int probNum = 0;
            Console.WriteLine("Enter a problem number from 7-7");
            string input = Console.ReadLine();
            while (!Int32.TryParse(input, out probNum) || probNum < 7 || probNum > 7)
            {
                Console.WriteLine("Invalid input. Please enter a problem number in range 7-7");
                input = Console.ReadLine();
            }
            Selector(probNum);
            Console.WriteLine("finished");
            Console.ReadLine();
        }

        // selects the problem the user wants to solve
        static void Selector(int probNum)
        {
            switch(probNum)
            {
                case 7:
                    Console.WriteLine(Problem7.Workout());
                    break;
                default:
                    Console.WriteLine("Problem not solved");
                    break;
            }
        }
    }
}
