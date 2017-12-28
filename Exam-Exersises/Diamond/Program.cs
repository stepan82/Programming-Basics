using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var outsideUpperDots = n - 1;
            var innerUpperDots = (5 * n) - (2 * n);
            var outsideDownDots = 1;
            var insideDownDots = (5*n) - 4;
            var ceilingDots = ((5 * n) - (n-2)) / 2;
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', innerUpperDots));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideUpperDots), new string('.', innerUpperDots));
                outsideUpperDots--;
                innerUpperDots+=2;
            }
            Console.WriteLine("{0}", new string('*', n*5));
            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDownDots), new string('.', insideDownDots));
                insideDownDots -= 2;
                outsideDownDots++;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', ceilingDots), new string('*', n-2));

        }
    }
}
