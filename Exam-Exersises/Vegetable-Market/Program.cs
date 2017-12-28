using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetable = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int kiloVegetables = int.Parse(Console.ReadLine());
            int kiloFruits = int.Parse(Console.ReadLine());
            var totalPriceVegetables = priceVegetable * kiloVegetables;
            var totalPriceFruits = priceFruits * kiloFruits;
            var total = (totalPriceFruits + totalPriceVegetables)/1.94;
            Console.WriteLine(total);
        }
    }
}
