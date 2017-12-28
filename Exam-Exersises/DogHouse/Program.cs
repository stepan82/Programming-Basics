using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var houseWall_A = double.Parse(Console.ReadLine());
            var househeight_B = double.Parse(Console.ReadLine());
            double doubleWall = (houseWall_A * (houseWall_A / 2.0)) * 2;
            double square = (houseWall_A / 2.0) * (houseWall_A / 2.0);
            double triangle = (houseWall_A / 2.0) * (househeight_B - (houseWall_A / 2));
            double triangleFinal = triangle / 2.0;
            double backWall = square + triangleFinal;
            double entrance = (houseWall_A / 5.0) * (houseWall_A / 5.0);
             double frontWall = backWall - entrance;
            double totalSquare = doubleWall + backWall + frontWall;
            double greenPaint = totalSquare / 3.0;
            double ceiling = (houseWall_A * (houseWall_A / 2.0)) * 2;
            double redPaint = ceiling / 5.0;
            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
