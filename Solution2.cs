﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutionsAMS
{
    class Solution2
    {
        static void Main(string[] args)
        {

            //Problem 2
            //Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting
            //with 1 and 2, the first 10 terms will be:            
            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the
            //sum of the even-valued terms.

            //Solution Description
            //This solution calculates numbers in the Fibonacci sequence using 3 variables. It also utilizes a
            //do/while loop which continues to execute while the 3 terms are less than 4,000,000. 

            
            int termA = 1;
            int termB = 2;
            int termC = 0;

            int sumOfEvenTerms = 2;

            do
            {
                termC = termA + termB;

                if (termC % 2 == 0)
                {
                    sumOfEvenTerms += termC;
                }

                termA = termC;
                
                termB += termA;

                if (termB % 2 == 0)
                {
                    sumOfEvenTerms += termB;
                }

            } while (termC < 4000000 && termB < 4000000 && termA < 4000000);
            

            Console.WriteLine("The sum of the even Fibonacci terms below 4,000,000 is: " + sumOfEvenTerms);
            Console.ReadKey();
        }
    }
}
