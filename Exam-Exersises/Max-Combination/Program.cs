using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var startInterval = int.Parse(Console.ReadLine());
            var endInterval = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());
            var currentCombinations = 0;
            for (int first = startInterval; first <= endInterval; first++)
            {
                for (int second = startInterval; second <= endInterval; second++)
                {
                    Console.Write($"<{first}-{second}>");
                    currentCombinations++;
                    if (currentCombinations == maxCombinations)
                    {
                        break;
                    }
                }
                if (currentCombinations == maxCombinations)
                {
                    break;
                }
            }
        }
    }
}
