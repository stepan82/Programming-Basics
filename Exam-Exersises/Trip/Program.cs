using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            if (budget <= 100.00 && season == "summer")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:F2}", budget * 0.3);
            }
            else if (budget <= 100.00 && season == "winter")
            {
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:F2}", budget * 0.7);
            }

            else if (budget > 100.00 && budget <= 1000 && season == "summer")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:F2}", budget * 0.4);
            }

            else if (budget > 100.00 && budget <= 1000 && season == "winter")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:F2}", budget * 0.8);
            }

            else if (budget > 1000 && (season == "summer" || season == "winter"))
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", budget * 0.9);
            }
        }
    }
}
