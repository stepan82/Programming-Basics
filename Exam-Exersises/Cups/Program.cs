using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsNumber = int.Parse(Console.ReadLine());
            var workersNumber = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());
            var workingHours = workersNumber * workingDays * 8;
            var cupsMade = Math.Floor(workingHours / 5.0);
            if (cupsMade < cupsNumber)
            {
                Console.WriteLine($"Losses: {(cupsNumber - cupsMade) * 4.20:F2}");
            }
            else
            {
                Console.WriteLine($"{(cupsMade - cupsNumber) * 4.20:F2} extra money");
            }
        }
    }
}
