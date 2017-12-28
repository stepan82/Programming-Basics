using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var pricePerSquare = double.Parse(Console.ReadLine());
            var secondRoom = smallestRoom + (smallestRoom * 0.1);
            var tirthRoom = secondRoom + (secondRoom * 0.1);
            var bathRoom = smallestRoom / 2;
            var houseSquare = (smallestRoom + kitchen + secondRoom + tirthRoom + bathRoom) + ((smallestRoom + kitchen + secondRoom + tirthRoom + bathRoom) * 0.05);
            var priceTotal = houseSquare * pricePerSquare;
            Console.WriteLine($"{priceTotal:F2}");
        }
    }
}
