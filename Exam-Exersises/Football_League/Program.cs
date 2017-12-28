using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var stadiumCapacity = double.Parse(Console.ReadLine());
            var supportersNumber = int.Parse(Console.ReadLine());
            var totalFansPerSector_A = 0.0;
            var totalFansPerSector_B = 0.0;
            var totalFansPerSector_V = 0.0;
            var totalFansPerSector_G = 0.0;
            var totalFansPerc = (supportersNumber / stadiumCapacity) * 100;
            for (int i = 1; i <= supportersNumber; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    totalFansPerSector_A += 1;
                }
                else if (sector == "B")
                {
                    totalFansPerSector_B += 1;
                }
                else if (sector == "V")
                {
                    totalFansPerSector_V += 1;
                }
                else if (sector == "G")
                {
                    totalFansPerSector_G += 1;
                }
                
            }

            var totalFansPerc_A = (totalFansPerSector_A / supportersNumber) * 100;
            var totalFansPerc_B = (totalFansPerSector_B / supportersNumber) * 100;
            var totalFansPerc_V = (totalFansPerSector_V / supportersNumber) * 100;
            var totalFansPerc_G = (totalFansPerSector_G / supportersNumber) * 100;

            Console.WriteLine($"{totalFansPerc_A:F2}%");
            Console.WriteLine($"{totalFansPerc_B:F2}%");
            Console.WriteLine($"{totalFansPerc_V:F2}%");
            Console.WriteLine($"{totalFansPerc_G:F2}%");
            Console.WriteLine($"{totalFansPerc:F2}%");


        }
    }
}
