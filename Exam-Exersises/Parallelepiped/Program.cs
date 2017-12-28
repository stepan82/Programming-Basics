using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (3 * n) + 1;
            var upperOutsideDots_1 = 0;
            var upperOutsideDots_2 = n * 2;
            var floorOutDots_1 = 0;
            var floorInDots = n * 2;
            Console.WriteLine("+{0}+{1}", new string('~', n-2), new string('.', width - 2 - (n-2)));

            for (int i = 1; i <= (n*2)+1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', upperOutsideDots_1), new string('~', n-2), new string('.', upperOutsideDots_2));
                upperOutsideDots_1++;
                upperOutsideDots_2--;
            }

            for (int i = 1; i <= (n*2)+1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', floorOutDots_1), new string('.', floorInDots), new string('~', n-2));
                floorOutDots_1++;
                floorInDots--;
            }
            Console.WriteLine("{0}+{1}+", new string('.', width - (n-2) - 2), new string('~', n-2));
        }
    }
}
