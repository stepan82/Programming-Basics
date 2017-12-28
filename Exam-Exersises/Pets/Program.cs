using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodTotal = int.Parse(Console.ReadLine());
            var foodDogDay = double.Parse(Console.ReadLine());
            var foodCatDay = double.Parse(Console.ReadLine());
            var foodTurtuleDay = double.Parse(Console.ReadLine());
            var foodDogTotal = foodDogDay * days;
            var foodCatTotal = foodCatDay * days;
            var foodTurtuleTotal = (foodTurtuleDay * days) / 1000;
            var foodNeeded = foodDogTotal + foodCatTotal + foodTurtuleTotal;
            if(foodNeeded <= foodTotal)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodTotal - foodNeeded));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodNeeded - foodTotal));
            }
        }
    }
}
