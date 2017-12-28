using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumbuls = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactuses = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());
            var totalIncome = (magnolii * 3.25) + (zumbuls * 4.00) + (roses * 3.50) + (cactuses * 8.00);
            var incomeTaxes = totalIncome - (totalIncome * 0.05);
            if(incomeTaxes >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor((incomeTaxes - presentPrice)));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling((presentPrice - incomeTaxes)));
            }
        }
    }
}
