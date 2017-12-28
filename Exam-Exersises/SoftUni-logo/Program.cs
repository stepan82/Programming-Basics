using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (12 * n) - 5;
            var outerUpperDots = (width - 7) / 2;
            var innerUpperSign = 7;
            var outerMiddleDots_1 = 2;
            var outerMIddleDots_2 = 3;
            var innerMiddleSign = width - 6;
            var innerFloorSign = (n * 6) + 1;
        
            Console.WriteLine("{0}#{0}", new string('.', (width-1)/2));

            for (int i = 1; i <= (n*2) - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', outerUpperDots), new string('#', innerUpperSign));
                outerUpperDots -= 3;
                innerUpperSign += 6;
            }

            Console.WriteLine("{0}", new string('#', width));

            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', outerMiddleDots_1), new string('#', innerMiddleSign), new string('.', outerMIddleDots_2));
                outerMiddleDots_1 += 3;
                outerMIddleDots_2 += 3;
                innerMiddleSign -= 6;
            }

            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', ((width-innerFloorSign)/2)-1), new string('#', innerFloorSign), new string('.', (width-innerFloorSign)/2));
            }

            Console.WriteLine("@{0}{1}{2}", new string('.', ((width - innerFloorSign) / 2) - 1), new string('#', innerFloorSign), new string('.', (width - innerFloorSign) / 2));
        }
    }
}
