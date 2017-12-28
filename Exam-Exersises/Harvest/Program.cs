using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var premisisSquare = double.Parse(Console.ReadLine());
            var grapePerSquare = double.Parse(Console.ReadLine());
            var wineLitres = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var grapeTotal = premisisSquare * grapePerSquare;
            var wine = (grapeTotal * 0.4) / 2.5;
            if(wine >= wineLitres)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - wineLitres), Math.Ceiling((wine - wineLitres) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineLitres - wine));
            }
        }
    }
}
