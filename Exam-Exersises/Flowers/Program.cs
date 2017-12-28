using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            string hollyday = Console.ReadLine();
            var flowersTotal = roses + hrizantemi + laleta;
            double priceSpringSummer = (2 * 2.00) + (laleta * 2.50) + (roses * 4.10);
            double priceAutumnWinter = (hrizantemi * 3.75) + (laleta * 4.15) + (roses * 4.50);
            double pricePlusHolly_S = priceSpringSummer + (priceSpringSummer * 0.15);
            double pricePlusHolly_AW = priceAutumnWinter + (priceAutumnWinter * 0.15);
            double priceDicsLale_Spr = pricePlusHolly_S - (pricePlusHolly_S * 0.05);
            double priceDiscRoses_AW = pricePlusHolly_AW - (pricePlusHolly_AW * 0.10);

            double totalPrice = 2.0;

            if (season == "Spring" && hollyday == "Y" && laleta > 7 && flowersTotal > 20)
            {

                totalPrice += priceDicsLale_Spr - (priceDicsLale_Spr * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (season == "Spring" && hollyday == "Y" && laleta > 7 && flowersTotal <= 20)
            {
                totalPrice += priceDicsLale_Spr;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Spring" || season == "Summer") && hollyday == "Y" && flowersTotal > 20)
            {
                totalPrice += pricePlusHolly_S - (pricePlusHolly_S * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Spring" || season == "Summer") && hollyday == "Y" && laleta <= 7 && flowersTotal <= 20)
            {
                totalPrice += pricePlusHolly_S;
                Console.WriteLine($"{totalPrice:F2}");


            }

            else if (season == "Spring" && hollyday == "N" && laleta > 7 && flowersTotal > 20)
            {
                totalPrice += priceSpringSummer - (priceSpringSummer * 0.05) - ((priceSpringSummer - (priceSpringSummer * 0.5)) * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Spring") && hollyday == "N" && laleta > 7 && flowersTotal <= 20)
            {
                totalPrice += priceSpringSummer - (priceSpringSummer * 0.05);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Spring" || season == "Summer") && hollyday == "N" && flowersTotal > 20)
            {
                totalPrice += priceSpringSummer - (priceSpringSummer * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Spring" || season == "Summer") && hollyday == "N" && laleta <= 7 && flowersTotal <= 20)
            {
                Console.WriteLine($"{totalPrice + priceSpringSummer:F2}");
            }











            if (season == "Winter" && hollyday == "Y" && roses >= 10 && flowersTotal > 20)
            {
                totalPrice += priceDiscRoses_AW - (priceDiscRoses_AW * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (season == "Winter" && hollyday == "Y" && roses >= 10)
            {
                totalPrice += priceDiscRoses_AW;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Autumn" || season == "Winter") && hollyday == "Y" && flowersTotal > 20)
            {
                totalPrice += pricePlusHolly_AW - (pricePlusHolly_AW * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Autumn" || season == "Winter") && hollyday == "Y" && roses < 10 && flowersTotal <= 20)
            {
                Console.WriteLine($"{totalPrice + pricePlusHolly_AW}");
            }



            else if (season == "Winter" && hollyday == "N" && roses >= 10 && flowersTotal > 20)
            {
                var n_1 = (priceAutumnWinter - (priceAutumnWinter * 0.10));
                var n_2 = n_1 - (n_1 * 0.20);
                totalPrice += n_2;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (season == "Winter" && hollyday == "N" && roses >= 10)
            {
                totalPrice += priceAutumnWinter - (priceAutumnWinter * 0.10);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Autumn" || season == "Winter") && hollyday == "N" && flowersTotal > 20)
            {
                totalPrice += priceAutumnWinter - (priceAutumnWinter * 0.20);
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if ((season == "Autumn" || season == "Winter") && hollyday == "N" && roses < 10 && flowersTotal <= 20)
            {
                Console.WriteLine($"{totalPrice + priceAutumnWinter:F2}");
            }
        }
    }
}
