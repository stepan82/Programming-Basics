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
            var groupsNumber = int.Parse(Console.ReadLine());
            var car = 0.0;
            var microbus = 0.0;
            var bus = 0.0;
            var coach = 0.0;
            var train = 0.0;
            for (int i = 1; i <= groupsNumber; i++)
            {
                var touristsPerGroup = int.Parse(Console.ReadLine());
                if (touristsPerGroup <= 5)
                {
                    car += touristsPerGroup;
                }
                else if (touristsPerGroup >= 6 && touristsPerGroup <=12)
                {
                    microbus += touristsPerGroup;
                }
                else if(touristsPerGroup >= 13 && touristsPerGroup <= 25)
                {
                    bus += touristsPerGroup;
                }
                else if (touristsPerGroup >= 26 && touristsPerGroup <= 40)
                {
                    coach += touristsPerGroup;
                }
                else if (touristsPerGroup >=41)
                {
                    train += touristsPerGroup;
                }
            }
            var total = car + microbus + bus + coach + train;

            double Perc_Car = (car / total) * 100;
            double Perc_Microbus = (microbus / total) * 100;
            double Perc_Bus = (bus / total) * 100;
            double Perc_Coach = (coach / total) * 100;
            double Perc_Train = (train / total) * 100;


            Console.WriteLine($"{Perc_Car:F2}%");
            Console.WriteLine($"{Perc_Microbus:F2}%");
            Console.WriteLine($"{Perc_Bus:F2}%");
            Console.WriteLine($"{Perc_Coach:F2}%");
            Console.WriteLine($"{Perc_Train:F2}%");


        }
    }
}
