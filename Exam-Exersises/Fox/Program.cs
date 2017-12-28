using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (2 * n) + 3;
            var innerUpperDash = width - 4;
            var outerUpperStars = 1;
            var innerDownStars = width - 4;
            var outerDownDash = 1;
            var outerCenterStars = n / 2;
            var innerCenterStars = width - ((n / 2) * 2) - 4;
            //ceiling
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', outerUpperStars), new string('-', innerUpperDash));
                innerUpperDash -= 2;
                outerUpperStars++;
            }

            //center
            for (int i = 1; i <= n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', outerCenterStars), new string('*', innerCenterStars));
                outerCenterStars++;
                innerCenterStars -= 2;
            }


            //floor
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', outerDownDash), new string('*', innerDownStars));
                outerDownDash++;
                innerDownStars -= 2;
            }
        }
    }
}
