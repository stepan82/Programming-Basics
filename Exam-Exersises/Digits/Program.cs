using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstDigit = n / 100;
            var secondDigit = (n % 100) / 10;
            var tirdthDigit = n % 10;
            var row = firstDigit + secondDigit;
            var numberOfNumbers = firstDigit + tirdthDigit;
            var currentN = n;
            for (int i = 1; i <= row; i++)
            {
                for (int number = 0; number < numberOfNumbers; number++)
                {
                    if (currentN % 5 == 0)
                    {
                        currentN -= firstDigit;
                        Console.Write($"{currentN} ");
                    }
                    else if (currentN % 3 == 0)
                    {
                        currentN -=secondDigit;

                    Console.Write($"{currentN} ");
                    }
                    else if (currentN % 5 != 0 && currentN % 3 != 0)
                    {
                        currentN += tirdthDigit;
                        Console.Write($"{currentN} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
