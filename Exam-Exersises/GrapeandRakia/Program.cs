using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeandRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var landSquare = double.Parse(Console.ReadLine());
            var grapePerSquare = double.Parse(Console.ReadLine());
            var trashGrape = double.Parse(Console.ReadLine());
            var totalGrape = landSquare * grapePerSquare;
            var totalGrapeMinustrash = totalGrape - trashGrape;
            var forRakia = totalGrapeMinustrash * 0.45;
            var litresRakia = forRakia / 7.5;
            var incomRakia = litresRakia * 9.80;
            var forSelling = totalGrapeMinustrash * 0.55;
            var incomGrape = forSelling * 1.50;
            Console.WriteLine($"{incomRakia:F2}");
            Console.WriteLine($"{incomGrape:F2}");
        }
    }
}
