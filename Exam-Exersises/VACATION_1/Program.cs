using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VACATION_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (money <= 1000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Camp - {money * 0.65:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Camp - {money * 0.45:F2}");
                }
            }

            else if (money > 1000 && money <= 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hut - {money * 0.80:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hut - {money * 0.60:F2}");
                }
            }



            else if (money > 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {money * 0.90:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hotel - {money * 0.90:F2}");
                }

            }
        }
    }
}
