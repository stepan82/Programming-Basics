using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pairsFound = 0;
            for (int firstNumber = 1; firstNumber <= 30; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 30; secondNumber++)
                {
                    for (int thirdNumber = 1; thirdNumber <= 30; thirdNumber++)
                    {
                        if (firstNumber + secondNumber + thirdNumber == n && firstNumber < secondNumber && secondNumber < thirdNumber) 
                        {
                            pairsFound++;
                            Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumber} = {n}");
                        }
                        else if (firstNumber * secondNumber * thirdNumber == n && firstNumber > secondNumber && secondNumber > thirdNumber)
                        {
                            Console.WriteLine($"{firstNumber} * {secondNumber} * {thirdNumber} = {n}");
                            pairsFound++;
                        }
                    }
                }
            }
            if (pairsFound == 0)
            {
                Console.WriteLine("No!");
            }  
        }
    }
}
