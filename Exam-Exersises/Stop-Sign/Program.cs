using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (n * 4) + 3;
            var upperOutDots = n;
            var upperInDashes = width - (2 * n) - 4;
            var downOutDots = 1;
            var downInDashes = width - 6;
            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_', width-(2*(n+1))));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', upperOutDots), new string('_', upperInDashes));
                upperOutDots--;
                upperInDashes += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (width-9)/2));
            Console.WriteLine("\\\\{0}//", new string('_', width-4));

            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', downOutDots), new string('_', downInDashes));
                downOutDots++;
                downInDashes -= 2;
            }
        }
    }
}
