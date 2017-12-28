using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometres = double.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            var lowestPrice = 0.0;
            if(kilometres < 20 && partOfDay == "day")
            {
                lowestPrice = (kilometres * 0.79) + 0.70;
            }
            else if (kilometres < 20 && partOfDay == "night")
            {
                lowestPrice = (kilometres * 0.90) + 0.70;
            }
            else if (kilometres >= 20 && kilometres < 100)
            {
                lowestPrice = kilometres * 0.09;
            }
            else if (kilometres >= 100)
            {
                lowestPrice = kilometres * 0.06;
            }
            Console.WriteLine(lowestPrice);
        }
    }
}
