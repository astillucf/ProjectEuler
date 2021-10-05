using System;

namespace ProjectEulerSolutionsAMS
{
    class Solution1
    {
        static void Main(string[] args)
        {

            //Problem 1
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these 
            //multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
            
            //Solution Description
            //This solution loops through each number between 1 and 999. If the number is either a multiple of 3 or 5, the 
            //running total for sum of multiples is incremented by that number. The solution uses an else if statement to 
            //prevent a number from being added more than once.

            int counter = 0;
            int sumOfMultiples = 0;
            int input = 1000;

            for (counter = 1; counter < input; counter++)
            {               
                if (counter % 3 == 0)
                {
                    sumOfMultiples += counter;
                }
                else if (counter % 5 == 0)
                {
                    sumOfMultiples += counter;
                }
            }

            Console.WriteLine("The sum of the multiples of 3 or 5 below " + input + " is: " + sumOfMultiples);
            Console.ReadKey();
        }
    }
}
