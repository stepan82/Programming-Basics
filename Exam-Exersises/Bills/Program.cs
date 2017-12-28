using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var water = months * 20.00;
            var internet = months * 15.00;
            var electricity = 0.0;
            var other = 0.0;
            for (int i = 1; i <= months; i++)
            {
                var electricityBill = double.Parse(Console.ReadLine());
                electricity += electricityBill;
                other += (electricityBill + 20.00 + 15.00) + ((electricityBill + 20.00 + 15.00) * 0.20);
            }
            var average = (water + internet + electricity + other) / months;
            Console.WriteLine($"Electricity: {electricity:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {other:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
