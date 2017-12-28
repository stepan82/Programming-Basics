using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            var measureX = double.Parse(Console.ReadLine());
            var measureY = double.Parse(Console.ReadLine());
            var measureH = double.Parse(Console.ReadLine());
            var sideWall = measureX * measureY;
            var window = 1.5 * 1.5;
            var doubleSideWalls = (2 * sideWall) - (2 * window);
            var backWall = measureX * measureX;
            var entrance = 1.2 * 2;
            var fronbackWalls = (2 * backWall) - entrance;
            var totalSquare = fronbackWalls + doubleSideWalls;
            var greenPaint = totalSquare / 3.4;
            var ceilingSquares = 2 * (measureX * measureY);
            var trinagleCeiling = 2 * (measureX * (measureH / 2));
            var totalSquareCeiling = trinagleCeiling + ceilingSquares;
            var redPaint = totalSquareCeiling / 4.3;
            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
