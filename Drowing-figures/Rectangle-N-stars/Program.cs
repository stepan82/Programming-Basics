using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_N_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int row = 0; row < number; row++)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
