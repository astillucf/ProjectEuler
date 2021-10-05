using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutionsAMS
{
    class Solution3
    {
        public static bool IsPrime(int product)
        {
            int counter = 0;
            int remainder = 0;

            for (counter = 2; counter <= Math.Sqrt(product); counter++)
            {
                remainder = product % counter;

                if (remainder == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {

            //Problem 3
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143?

            //Solution Description
            //This solution uses the square root of the given number as the upper bound for its loops. It then
            //iterates backwards from this number until it finds a number that is a factor. It then uses the
            //function IsPrime to determine if the number is prime or not. If the number is prime, the loop breaks
            //and the solution is found.
            //
            //The function IsPrime uses a similar upper bound and iterates through each number between 2 and
            //the square root of the number being tested. If at any point the number being tested is evenly
            //divisible by the iterating number, the given number cannot be prime and a false result is returned.


            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            int largestPrime = 0;
            int counter = 0;
            long product = 600851475143;

            for (counter = Convert.ToInt32(Math.Sqrt(product)); counter > 1; counter--)
            {
                if (product % counter == 0)
                {
                    if (IsPrime(counter))
                    {
                        largestPrime = counter;
                        break;
                    }
                }
            }


            watch.Stop();

            Console.WriteLine("The largest prime factor of " + product + " is: " + largestPrime);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
}
