using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char avoidLetter = char.Parse(Console.ReadLine());
            var currentCombinations = 0;
            for (char first = firstLetter; first <= lastLetter; first++)
            {
                if (first == avoidLetter)
                {
                    break;
                }
                for (int second = firstLetter; second <= lastLetter; second++)
                {
                    if (second == avoidLetter)
                    {
                        break;
                    }
                    for (int third = firstLetter; third <= lastLetter; third++)
                    {
                        if (third == avoidLetter)
                        {
                            break;
                        }
                        Console.Write("{0}{1}{2}", first, second, third);
                        currentCombinations++;
                    }
                }
            }
        }
    }
}
