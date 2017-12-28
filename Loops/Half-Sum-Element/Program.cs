using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var sumOfNumbers = 0;
            var biggestNumber = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sumOfNumbers += number;
                if(number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            if ((sumOfNumbers - biggestNumber) == biggestNumber)
            {
                Console.WriteLine($"Yes Sum = {biggestNumber}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(biggestNumber - (sumOfNumbers - biggestNumber))}");
            }
        }
    }
}
