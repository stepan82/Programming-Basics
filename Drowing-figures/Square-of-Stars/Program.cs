using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int row = 0; row < number; row++)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
