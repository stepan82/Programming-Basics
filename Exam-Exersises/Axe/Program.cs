using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var upperOutsideDash = (2 * n) - 2;
            var preFinalRow = (2 * n) - n - (n / 2) - 1;
            var preFinalDassh_1 = (n * 3);
            var preFinalDassh_2 = n - 1;
            var preFinalDassh_3 = n - 1;

            if (n % 2 != 0)
            {
                preFinalRow = (2 * n) - n - (n / 2) - 2;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', n*3), new string('-', i), new string('-', upperOutsideDash));
                upperOutsideDash--;
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}*{1}", new string('*', (n * 3) + 1), new string('-', n - 1));
            }


            for (int i = 0; i < preFinalRow; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', preFinalDassh_1), new string('-', preFinalDassh_2), new string('-', preFinalDassh_3));
                preFinalDassh_1--;
                preFinalDassh_2 += 2;
                preFinalDassh_3--;

            }
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', (5 * n) - (n / 2) - ((n * 2) - 1)), new string('*', (n * 2) - 1), new string('-', n / 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", new string('-', 3 * n - (n / 2) + 1), new string('*', 5 * n - (3 * n - (n / 2) + 1) - (n - n / 2)), new string('-', n - n / 2));
            }


        }
    }
}
