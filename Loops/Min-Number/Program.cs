using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersEntered = int.Parse(Console.ReadLine());
            var minNumber = 1000000000000000000;
            for (int i = 0; i < numbersEntered; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
