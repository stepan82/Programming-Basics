using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityName = Console.ReadLine();
            var sellings = double.Parse(Console.ReadLine());
            if(cityName == "Sofia" && (sellings >= 0 && sellings <= 500))
            {
                Console.WriteLine("{0:f2}", sellings * 0.05);
            }
            else if (cityName == "Sofia" && (sellings > 500 && sellings <= 1000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.07);
            }
            else if (cityName == "Sofia" && (sellings > 1000 && sellings <= 10000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.08);
            }
            else if (cityName == "Sofia" && (sellings > 10000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.12);
            }
            else if (cityName == "Varna" && (sellings >= 0 && sellings <= 500))
            {
                Console.WriteLine("{0:f2}", sellings * 0.045);
            }
            else if (cityName == "Varna" && (sellings > 500 && sellings <= 1000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.075);
            }
            else if (cityName == "Varna" && (sellings > 1000 && sellings <= 10000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.1);
            }
            else if (cityName == "Varna" && (sellings > 10000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.13);
            }
           
            else if (cityName == "Plovdiv" && (sellings >= 0 && sellings <= 500))
            {
                Console.WriteLine("{0:f2}", sellings * 0.055);
            }
            else if (cityName == "Plovdiv" && (sellings > 500 && sellings <= 1000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.08);
            }
            else if (cityName == "Plovdiv" && (sellings > 1000 && sellings <= 10000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.12);
            }
            else if (cityName == "Plovdiv" && (sellings > 10000))
            {
                Console.WriteLine("{0:f2}", sellings * 0.145);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
