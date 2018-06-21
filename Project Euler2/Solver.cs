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
            bool wantToSolve = true;
            while (wantToSolve)
            {
                int probNum = 0;
                Console.WriteLine("Enter a problem number from 7-10 or enter 0 to quit");
                string input = Console.ReadLine();
                while (!Int32.TryParse(input, out probNum) || (probNum < 7 || probNum > 10) && probNum != 0)
                {
                    Console.WriteLine("Invalid input. Please enter a problem number in range 7-10");
                    input = Console.ReadLine();
                }
                //Console.Write("The answer is: ");
                wantToSolve = Selector(probNum);
                //Console.WriteLine("\nDo you wish to solve another problem?");
                
            }
            Console.WriteLine("finished");
            Console.ReadLine();
        }

        // selects the problem the user wants to solve
        static bool Selector(int probNum)
        {
            switch(probNum)
            {
                case 0:
                    return false;
                case 7:
                    Console.WriteLine(Problem7.Workout());
                    break;
                case 8:
                    Console.WriteLine(Problem8.Workout());
                    break;
                case 9:
                    Console.WriteLine(Problem9.Workout());
                    break;
                case 10:
                    Console.WriteLine(Problem10.Workout());
                    break;
                default:
                    Console.WriteLine("Problem not solved");
                    break;
            }
            return true;
        }
    }
}
