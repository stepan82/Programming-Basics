using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
