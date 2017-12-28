using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lecturesNumber = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var payment = budget / lecturesNumber;
            var jelev_1 = 0;
            var royal_1 = 0;
            var roli_1 = 0;
            var trofon_1 = 0;
            var sino_1 = 0;
            var others_1 = 0;
            for (int i = 1; i <= lecturesNumber; i++)
            {
                string name = Console.ReadLine();
                if (name == "Jelev")
                {
                    jelev_1++;
                }
                else if (name == "RoYaL")
                {
                    royal_1++;
                }
                else if (name == "Roli")
                {
                    roli_1++;
                }
                else if (name == "Trofon")
                {
                    trofon_1++;
                }
                else if (name == "Sino")
                {
                    sino_1++;
                }
                else
                {
                    others_1++;
                }
            }

            Console.WriteLine($"Jelev salary: {payment * jelev_1:F2} lv");
            Console.WriteLine($"RoYaL salary: {payment * royal_1:F2} lv");
            Console.WriteLine($"Roli salary: {payment * roli_1:F2} lv");
            Console.WriteLine($"Trofon salary: {payment * trofon_1:F2} lv");
            Console.WriteLine($"Sino salary: {payment * sino_1:F2} lv");
            Console.WriteLine($"Others salary: {payment * others_1:F2} lv");

        }
    }
}
