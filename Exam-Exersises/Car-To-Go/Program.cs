using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (money <= 100)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Cabrio - {money * 0.35:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Jeep - {money * 0.65:F2}");
                }
            }

            else if (money > 100 && money <= 500)
            {
                if (season == "Summer")
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Cabrio - {money * 0.45:F2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Jeep - {money * 0.80:F2}");
                }
            }

            else if (money > 500 && (season == "Summer" || season == "Winter"))
            {
               
                    Console.WriteLine("Luxury class");
                    Console.WriteLine($"Jeep - {money * 0.90:F2}");
               
            }
        }
    }
}
