using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (4 * n) + 1;
            var height = (2 * n) + 1;
            var secondMiddleRows = height - 2 - (n / 2) - n;
            var outerDotsUpper = 1;
            var innerSpaceUpper = 1;
            var diesUpper = (width - 3) / 2;
            var outerDotsFloor= n + 1;
            var innerDiesFloor = width - ((n + 1) * 2);
            Console.WriteLine("{0}", new string('#', width));
            for (int i = 1; i <= n; i++)
            {
                if (i == (n/2)+1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', outerDotsUpper), new string('#', diesUpper), new string(' ', (width - (outerDotsUpper * 2) - (diesUpper * 2) - 3) / 2));

                    outerDotsUpper++;
                    diesUpper -= 2;
                    innerSpaceUpper += 2;
                }
                else 
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outerDotsUpper), new string('#', diesUpper), new string(' ', innerSpaceUpper));
                    outerDotsUpper++;
                    diesUpper -= 2;
                    innerSpaceUpper += 2;
                }
            } 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', outerDotsFloor), new string ('#', innerDiesFloor));
                outerDotsFloor++;
                innerDiesFloor -= 2;
            }
        }
    }
}
