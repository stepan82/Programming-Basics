using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var downDash = n * 2 - 4 - 2 * (n / 2);
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n/2), new string('_', downDash));
            for (int i = 0; i < n-3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', (n*2)-2));
            }
            Console.Write(new string('|', 1));
            Console.Write(new string(' ', n / 2 + 1));
            Console.Write(new string('_', n * 2 - 4 - 2 * (n / 2)));
            Console.Write(new string(' ', n / 2 + 1));
            Console.Write(new string('|', 1));
            Console.WriteLine();
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n/2), new string(' ', downDash));

        }
    }
}
