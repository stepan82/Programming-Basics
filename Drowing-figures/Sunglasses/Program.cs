using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
        #region beginning
 
                Console.Write(new string('*', 2 * n));
                Console.Write(new string (' ', n));
                Console.WriteLine(new string('*', 2 * n));
            #endregion

            for (int row = 0; row < n - 2; row++)
            {
                Console.Write('*');
                Console.Write(new string ('/', (2 * n) - 2));
                Console.Write('*');
                if(row == (n - 1) / 2 - 1)
                {
                    Console.Write(new string ('|', n));
                }
                else
                {
                    Console.Write(new string (' ', n));
                }
                Console.Write('*');
                Console.Write(new string('/', (2 * n) - 2));
                Console.Write('*');


                Console.WriteLine();
            }
        #region ending
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            #endregion
        }
    }
}
