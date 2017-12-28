using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniorBikers = int.Parse(Console.ReadLine());
            var bikers = int.Parse(Console.ReadLine());
            string race = Console.ReadLine();
            var sum = 0.0;
            var discJunior = 8 - (8 * 0.25);
            var discBikers = 9.50 - (9.50 * 0.25);
            if (race == "trail")
            {
                sum += (bikers * 7) + (juniorBikers * 5.50);
            }
            else if (race == "cross-country" && (juniorBikers + bikers) >= 50)
            {

                sum += (bikers * discBikers) + (juniorBikers * discJunior);
            }

            else if (race == "cross-country" && (juniorBikers + bikers) < 50)
            {
                sum += (bikers * 9.50) + (juniorBikers * 8);
            }  
            
            else if (race == "downhill")
            {
                sum += (bikers * 13.75) + (juniorBikers * 12.25);
            }
            else if (race == "road")
            {
                sum += (bikers * 21.50) + (juniorBikers * 20);
            }

            var total = sum - (sum * 0.05);

            Console.WriteLine($"{total:F2}");
        }
    }
}
