using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n;
            var outerCeilingDots = (width - 2) / 2;
            var innerCeilingSpace = 0;
            var outerFloorDots = n / 2;
            var innerFloorStars = width - ((n / 2) * 2) - 2;

            //ceiling
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outerCeilingDots), new string(' ', innerCeilingSpace));
                innerCeilingSpace+=2;
                outerCeilingDots--;

            }
            Console.WriteLine("{0}{1}{0}", new string('.', n/2), new string('*', width - ((n/2)*2)));

            // middle
            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n/2), new string('\\', width-((n/2)*2) - 2));
            }

            //floor
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outerFloorDots), new string('*', innerFloorStars));
                outerFloorDots--;
                innerFloorStars += 2;

            }
        }
    }
}
