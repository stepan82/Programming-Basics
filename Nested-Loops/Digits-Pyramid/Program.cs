using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int column = 0; column < i; column++)
                {
                    Console.Write("{0} ", count);
                    count++;
                    if (count > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (count > n) break;


            }
        }
    }
}
