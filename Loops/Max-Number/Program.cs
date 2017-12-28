using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersEntered = int.Parse(Console.ReadLine());
            var maxNumber = -1000000000000000000;
            for (int i = 0; i < numbersEntered; i ++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
