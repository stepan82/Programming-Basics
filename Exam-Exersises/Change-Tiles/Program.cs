using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double ceilingWidth = double.Parse(Console.ReadLine());
            double ceilingLong = double.Parse(Console.ReadLine());
            double triangleSite = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double price_1 = double.Parse(Console.ReadLine());
            double masterSalary = double.Parse(Console.ReadLine());
            var squareCeiling = ceilingLong * ceilingWidth;
            var squarePlate = (triangleSite * triangleHeight) / 2;
            var platesNeeded = (Math.Ceiling(squareCeiling / squarePlate)) + 5;
            var total = (platesNeeded * price_1) + masterSalary;
            if (total <= money)
            {
                Console.WriteLine($"{money - total:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {total - money:F2} lv more.");
            }
        }
    }
}
