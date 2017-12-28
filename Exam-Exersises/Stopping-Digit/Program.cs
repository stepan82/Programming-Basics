using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopping_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var lastNumber = int.Parse(Console.ReadLine());
            var stopNumber = int.Parse(Console.ReadLine());
            for (int i = lastNumber; i >= firstNumber; i--)
            {

                if (i % 2 == 0 && i % 3 == 0 && i == stopNumber)
                {
                    break;
                }
                else if (i%2 == 0 && i%3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
