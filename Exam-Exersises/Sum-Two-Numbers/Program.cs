using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var startInterval = int.Parse(Console.ReadLine());
            var endInterval = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var currentCombinations = 0;
            for (int first = startInterval; first <= endInterval; first++)
            {
                for (int second = startInterval; second <= endInterval; second++)
                {
                    currentCombinations++;
                    if ((first + second) == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{currentCombinations} ({first} + {second} = {magicNumber})");
                        goto End;
                    }
                    else if ((first + second) != magicNumber && first == endInterval && second == endInterval)
                    {
                        goto End_2;
                    }
                }
            }
           

            End_2:
            Console.WriteLine($"{currentCombinations} combinations - neither equals {magicNumber}");
            End:;
        }

    }
}
