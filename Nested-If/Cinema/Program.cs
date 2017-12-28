using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            if(plan == "Premiere")
            {
                Console.WriteLine($"{(rows * columns) * 12.00:F2} leva");
            }
            else if(plan == "Normal")
            {
                Console.WriteLine($"{(rows * columns) * 7.50:F2} leva");
            }
            else if (plan == "Discount")
            {
                Console.WriteLine($"{(rows * columns) * 5.00:F2} leva");
            }
        }
    }
}
