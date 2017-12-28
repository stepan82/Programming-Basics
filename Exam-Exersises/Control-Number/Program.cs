using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var startInterval = int.Parse(Console.ReadLine());
            var endInterval = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            var currentCombinations = 0;
            var sum = 0;
            for (int first = 1; first <= startInterval; first++)
            {
                for (int second = endInterval; second >= 1; second--)
                {
                    currentCombinations++;
                    sum += (first * 2) + (second * 3);
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{currentCombinations} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        goto End;
                    }
                    else if (sum < controlNumber && first == startInterval && second == 1)
                    {
                        goto Write;
                    }
                }
            }


            Write:
            Console.WriteLine($"{currentCombinations} moves");
            End:;
        }

    }
}
