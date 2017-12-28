using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfDigits = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (int i = 0; i < numberOfDigits; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum = oddSum + number;
                }
                else
                {
                    evenSum = evenSum + number;
                }
            }
            if(oddSum == evenSum)
            {
                Console.WriteLine("Yes Sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
