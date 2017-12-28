using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kilometresPerMonth = double.Parse(Console.ReadLine());
            var salary = 0.0;
            if (kilometresPerMonth <= 5000 && (season == "Spring" || season == "Autumn"))
            {
                salary += (kilometresPerMonth * 0.75) * 4;
            }
            else if (kilometresPerMonth <= 5000 && season == "Summer")
            {
                salary += (kilometresPerMonth * 0.90) * 4;
            }
            else if (kilometresPerMonth <= 5000 && season == "Winter")
            {
                salary += (kilometresPerMonth * 1.05) * 4;
            }

            if (kilometresPerMonth > 5000 && kilometresPerMonth <=10000 && (season == "Spring" || season == "Autumn"))
            {
                salary += (kilometresPerMonth * 0.95) * 4;
            }
            else if (kilometresPerMonth > 5000 && kilometresPerMonth <= 10000 && season == "Summer")
            {
                salary += (kilometresPerMonth * 1.10) * 4;
            }
            else if (kilometresPerMonth > 5000 && kilometresPerMonth <= 10000 && season == "Winter")
            {
                salary += (kilometresPerMonth * 1.25) * 4;
            }


            if (kilometresPerMonth > 10000 && kilometresPerMonth <= 20000 && (season == "Spring" || season == "Autumn" || season == "Summer" || season == "Winter"))
            {
                salary += (kilometresPerMonth * 1.45) * 4;
            }

            Console.WriteLine($"{salary - (salary * 0.10):F2}");
           
        }
    }
}
