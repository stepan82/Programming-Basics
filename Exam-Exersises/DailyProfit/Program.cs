using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var dailyIncome = double.Parse(Console.ReadLine());
            var dollarLeva = double.Parse(Console.ReadLine());
            var monthlyIncome = workingDays * dailyIncome;
            var yearlyIncome = (monthlyIncome * 12) + (monthlyIncome * 2.5);
            var taxes = yearlyIncome * 0.25;
            var finalIncome = (yearlyIncome - taxes) * dollarLeva;
            var dailyIncomeFinal = finalIncome / 365;
            Console.WriteLine(Math.Round(dailyIncomeFinal, 2));
        }
    }
}
