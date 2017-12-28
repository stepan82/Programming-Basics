using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var baggageNumber = int.Parse(Console.ReadLine());
            var totalTons = 0;
            var microbus = 0.0;
            var lorry = 0.0;
            var train = 0.0;
            for (int i = 1; i <= baggageNumber; i++)
            {
                var baggage_tons = int.Parse(Console.ReadLine());
                if (baggage_tons <= 3)
                {
                    microbus += baggage_tons;
                    totalTons += baggage_tons;
                }

                else if (baggage_tons > 3 && baggage_tons <= 11)
                {
                    lorry += baggage_tons;
                    totalTons += baggage_tons;
                }
                else if (baggage_tons > 11)
                {
                    train += baggage_tons;
                    totalTons += baggage_tons;
                   
                }
            }

            var middlePrice = ((microbus * 200) + (lorry * 175) + (train * 120)) / totalTons;

            double Perc_Microbus = (microbus / totalTons) * 100;
            double Perc_Lorry = (lorry / totalTons) * 100;
            double Perc_Train = (train / totalTons) * 100;


            Console.WriteLine($"{middlePrice:F2}");
            Console.WriteLine($"{Perc_Microbus:F2}%");
            Console.WriteLine($"{Perc_Lorry:F2}%");
            Console.WriteLine($"{Perc_Train:F2}%");
        }
    }
}
