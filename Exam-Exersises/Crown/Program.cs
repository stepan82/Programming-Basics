using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var crownCeiling = (2 * n) - 4;
            var secondRow = (2 * n) - 6;
            var countOfExcept = ((2 * n) - 1) - (n + 3);
            var countOfExcept_2 = countOfExcept / 2;
            Console.WriteLine("@{0}@{0}@", new string(' ', crownCeiling / 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', secondRow / 2));
            var externalDots = 1;
            var internalDots = 1;
            var spaces = ((2 * n) - 10) / 2;
            for (int i = 1; i <= (n / 2 )-2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', externalDots), new string(' ', spaces), 
                    new string ('.', internalDots));
                externalDots += 1;
                internalDots += 2;
                spaces -= 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n-2) / 2), new string ('.', n-3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', countOfExcept_2));
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(new string('*', (2 * n) - 1));
            }
        }
    }
}
