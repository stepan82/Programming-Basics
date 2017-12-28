using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (4 * n) + 1;
            var height = (2 * n) + 5;
            var outerMiddleDots = (n * 2) - 2;
            var innerMiddleDashes = 1;
            //ceiling
            Console.WriteLine("{0}/|\\{0}", new string('.', (2 * n) - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', (2 * n) - 1));
            Console.WriteLine("{0}***{0}", new string ('.', (width-3)/2));

            //middle
            for (int i = 1; i <= (n*2) - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerMiddleDots), new string('-', innerMiddleDashes));
                outerMiddleDots--;
                innerMiddleDashes++;
            }

            //floor
            Console.WriteLine("{0}", new string('*', width));
            for (int i = 1; i <= width; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}", new string('*', width));

        }
    }
}
