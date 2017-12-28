using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfParts = int.Parse(Console.ReadLine());
            var moneyPrice = double.Parse(Console.ReadLine());
            var totalPoints = 0;
            for (int i = 1; i <= numberOfParts; i++)
            {
                var points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    totalPoints += points * 2;
                }
                else
                {
                    totalPoints += points;
                }
            }
            var finalPrice = totalPoints * moneyPrice;
            Console.WriteLine($"The project prize was {finalPrice:F2} lv.");
        }
    }
}
