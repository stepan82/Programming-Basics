using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n + 1; row++)
            {
                Console.Write(new string (' ', (n + 1) - row));
                Console.Write(new string ('*', row - 1));
                Console.Write(" | ");
                Console.Write(new string('*', row - 1));
                Console.WriteLine();
            }
           
           
            
        }
    }
}
