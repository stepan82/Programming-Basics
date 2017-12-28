using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("| ");
                for (int column = 0; column < number - 2; column++)
                {
                    Console.Write("- ");
                }

                Console.WriteLine("|");
            }


            Console.Write("+ ");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
        }
    }
}
