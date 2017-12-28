using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
          
                    var a = i % 10;
                    var b = i % 100/10;
                    var c = i % 1000/100;
                    var d = i % 10000/1000;

                if (a == 0 || b == 0 || c == 0 || d == 0)
                {
                    continue;
                }
                if (n % a == 0 && n % b == 0 && n % c == 0 && n % d == 0)
                    {
                        Console.Write($"{i} ");
                    }
                
            }
            Console.WriteLine();

        }
    }
}
