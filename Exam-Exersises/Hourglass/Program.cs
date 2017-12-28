using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (2 * n) + 1;
            var upperLoopDot = 2;
            var upperLoopSign = width - (upperLoopDot * 2) - 2;
            var floorLoopDot = n - 1;
            var floorLoopSpace = 0;
            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine(".*{0}*.", new string(' ', width - 4));
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', upperLoopDot), new string('@', upperLoopSign));
                upperLoopDot++;
                upperLoopSign -= 2;
            }
            Console.WriteLine("{0}*{0}", new string('.', (width-1)/2));
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', floorLoopDot), new string(' ', floorLoopSpace));
                floorLoopDot--;
                floorLoopSpace++;
            }
            Console.WriteLine(".*{0}*.", new string('@', width - 4));
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}
