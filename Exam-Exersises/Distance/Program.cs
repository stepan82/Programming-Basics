using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialSpeed = double.Parse(Console.ReadLine());
            var firstTime = double.Parse(Console.ReadLine());
            var secondTime = double.Parse(Console.ReadLine());
            var thirdTime = double.Parse(Console.ReadLine());
            var distanceFirstSpeed = initialSpeed * (firstTime / 60);
            var distanceIncreasingSpeed = (initialSpeed + (initialSpeed * 0.1)) * (secondTime / 60);
            var increasingSpeed = initialSpeed + (initialSpeed * 0.1);
            var distanceDecreasingSpeed = (increasingSpeed - (increasingSpeed * 0.05)) * (thirdTime / 60);
            var totalKilom = distanceDecreasingSpeed + distanceIncreasingSpeed + distanceFirstSpeed;
            Console.WriteLine($"{totalKilom:F2}");
        }
    }
}
