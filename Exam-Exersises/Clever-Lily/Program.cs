using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var lilyYears = int.Parse(Console.ReadLine());
            var machinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var totalMoney = 0;
            var totalToys = 0;
            var evenDays = 0;
            for (int i = 1; i <= lilyYears; i++)
            {
                if (i % 2 == 0 && i != 2)
                {
                    totalMoney += (i * 10) / 2;
                    evenDays++;
                }
                else if (i % 2 != 0)
                {
                    totalToys++;
                }
                else if (i == 2)
                {
                    totalMoney +=10;
                    evenDays++;
                }
            }
            var totalSumToys = totalToys * toyPrice;
            var totalSum = (totalMoney + totalSumToys) - (evenDays * 1);
            if (totalSum >= machinePrice)
            {
                Console.WriteLine($"Yes! {totalSum-machinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice-totalSum:F2}");
            }
        }
    }
}
