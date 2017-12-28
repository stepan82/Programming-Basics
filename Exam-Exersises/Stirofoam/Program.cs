using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stirofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double houseSquares = double.Parse(Console.ReadLine());
            var windowsNumber = int.Parse(Console.ReadLine());
            double stirofoamPackage = double.Parse(Console.ReadLine());
            double packagePrice = double.Parse(Console.ReadLine());
            var houseSquaresWindows = houseSquares - (windowsNumber * 2.4);
            var squaresExtra = houseSquaresWindows + (houseSquaresWindows * 0.10);
            var packagesNeeded = Math.Ceiling(squaresExtra / stirofoamPackage);
            var price = packagesNeeded * packagePrice;
            if (money >= price)
            {
                Console.WriteLine($"Spent: {price:F2}");
                Console.WriteLine($"Left: {money -price:F2}");
            }
            else
            {
                Console.WriteLine($"Need more: {price - money:F2}");
            }

        }
    }
}
