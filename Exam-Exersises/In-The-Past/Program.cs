using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var yearToLive = int.Parse(Console.ReadLine());
            double moneyNeed = 0;
            var yearsOld = 17;
            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyNeed += 12000;
                    yearsOld++;
                }
                else
                {
                    yearsOld++;
                    moneyNeed += 12000 + (50 * yearsOld);
                }
            }

            if (moneyNeed <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money - moneyNeed:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneyNeed - money:F2} dollars to survive.");
            }
        }
    }
}
