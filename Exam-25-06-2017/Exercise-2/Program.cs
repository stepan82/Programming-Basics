using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distanceMetres = double.Parse(Console.ReadLine());
            var timeFor_1_meter = double.Parse(Console.ReadLine());
            var timeTotal = timeFor_1_meter * distanceMetres;
            var extraDelay = Math.Floor(distanceMetres / 15.00);
            var extraTime = extraDelay * 12.5;
            var finalTime = extraTime + timeTotal;
            if (finalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - finalTime):F2} seconds slower.");
            }
        }
    }
}
