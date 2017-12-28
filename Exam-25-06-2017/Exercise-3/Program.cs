using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var sizeOfDrink = Console.ReadLine();
            var numberOFDrinks = int.Parse(Console.ReadLine());
            var price = 0.0;
            var priceTotal = 0.0;
            if (fruit == "Watermelon" && sizeOfDrink == "small")
            {
                price += 2 * 56.00;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <=1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Watermelon" && sizeOfDrink == "big")
            {
                price += 5 * 28.70;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Mango" && sizeOfDrink == "small")
            {
                price += 2 * 36.66;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Mango" && sizeOfDrink == "big")
            {
                price += 5 * 19.60;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Pineapple" && sizeOfDrink == "small")
            {
                price += 2 * 42.10;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Pineapple" && sizeOfDrink == "big")
            {
                price += 5 * 24.80;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Raspberry" && sizeOfDrink == "small")
            {
                price += 2 * 20.00;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            else if (fruit == "Raspberry" && sizeOfDrink == "big")
            {
                price += 5 * 15.20;
                priceTotal += price * numberOFDrinks;
                if (priceTotal >= 400.00 && priceTotal <= 1000)
                {
                    priceTotal -= priceTotal * 0.15;
                }
                else if (priceTotal > 1000.00)
                {
                    priceTotal -= priceTotal * 0.50;
                }
            }

            Console.WriteLine($"{priceTotal:F2} lv.");
        }
    }
}
