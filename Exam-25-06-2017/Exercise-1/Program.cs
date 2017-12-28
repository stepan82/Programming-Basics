using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var sladkari = int.Parse(Console.ReadLine());
            var cakesNumber = int.Parse(Console.ReadLine());
            var gofretiNumber = int.Parse(Console.ReadLine());
            var pancakesNumber = int.Parse(Console.ReadLine());
            var sumCakes = cakesNumber * 45.00;
            var sumGofreti = gofretiNumber*5.80;
            var sumPancakes = pancakesNumber * 3.20;
            var totalSumDay = (sumCakes + sumGofreti + sumPancakes) * sladkari;
            var campaignSum = totalSumDay * days;
            var spents = campaignSum - (campaignSum / 8);
            Console.WriteLine($"{spents:F2}");
        }
    }
}
