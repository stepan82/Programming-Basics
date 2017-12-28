using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var lung = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var lung_cm = lung * 100;
            var width_cm = width * 100;
            var count_1 = Math.Floor((width_cm - 100) / 70);
            var count_2 = Math.Floor(lung_cm / 120);

            var result = (count_1 * count_2) - 3;
            Console.WriteLine(result);
        }
    }
}
