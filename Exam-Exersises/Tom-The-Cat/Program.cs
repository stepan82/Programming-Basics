using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_The_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var offDays = int.Parse(Console.ReadLine());
            var offDays_MinutesPlay = offDays * 127;
            var onDays_MinutesPlay = (365 - offDays) * 63;
            var totalMinutes = offDays_MinutesPlay + onDays_MinutesPlay;
            var leavingMinutes = 30000 - totalMinutes;
            var overMinutes = totalMinutes - 30000;
            var hours = leavingMinutes / 60;
            var minutes = leavingMinutes - (hours * 60);
            var hours_1 = overMinutes / 60;
            var minutes_2 = overMinutes - (hours_1 * 60);
            if (totalMinutes <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else if (totalMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours_1} hours and {minutes_2} minutes more for play");
            }
        }
    }
}
