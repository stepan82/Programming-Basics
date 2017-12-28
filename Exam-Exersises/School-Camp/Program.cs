using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            var students_N = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var sport = "";
            var price = 0.0;
       
            if (season == "Winter" && gender == "girls")
            {
                sport = "Gymnastics";
                
                if (students_N >= 50)
                {
                    price += (9.60 * nights * students_N) - (9.60 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (9.60 * nights * students_N) - (9.60 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (9.60 * nights * students_N) - (9.60 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 9.60 * nights * students_N;
                }
            }

            else if (season == "Winter" && gender == "boys")
            {
                sport = "Judo";
               
                if (students_N >= 50)
                {
                    price += (9.60 * nights * students_N) - (9.60 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (9.60 * nights * students_N) - (9.60 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (9.60 * nights * students_N) - (9.60 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 9.60 * nights * students_N;
                }
            }

            else if (season == "Winter" && gender == "mixed")
            {
                sport = "Ski";
                
                if (students_N >= 50)
                {
                    price += (10 * nights * students_N) - (10 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (10 * nights * students_N) - (10 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (10 * nights * students_N) - (10 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 10 * nights * students_N;
                }
            }

            else if (season == "Spring" && gender == "girls")
            {
                sport = "Athletics";
               
                if (students_N >= 50)
                {
                    price += (7.20 * nights * students_N) - (7.20 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (7.20 * nights * students_N) - (7.20 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (7.20 * nights * students_N) - (7.20 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 7.20 * nights * students_N;
                }
            }

            else if (season == "Spring" && gender == "boys")
            {
                sport = "Tennis";
               
                if (students_N >= 50)
                {
                    price += (7.20 * nights * students_N) - (7.20 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (7.20 * nights * students_N) - (7.20 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (7.20 * nights * students_N) - (7.20 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 7.20 * nights * students_N;
                }
            }

            else if (season == "Spring" && gender == "mixed")
            {
                sport = "Cycling";
                
                if (students_N >= 50)
                {
                    price += (9.50 * nights * students_N) - (9.50 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (9.50 * nights * students_N) - (9.50 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (9.50 * nights * students_N) - (9.50 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 9.50 * nights * students_N;
                }
            }

            else if (season == "Summer" && gender == "girls")
            {
                sport = "Volleyball";
               
                if (students_N >= 50)
                {
                    price += (15 * nights * students_N) - (15 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (15 * nights * students_N) - (15 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (15 * nights * students_N) - (15 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 15 * nights * students_N;
                }
            }

            else if (season == "Summer" && gender == "boys")
            {
                sport = "Football";
                if (students_N >= 50)
                {
                    price += (15 * nights * students_N) - (15 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (15 * nights * students_N) - (15 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (15 * nights * students_N) - (15 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 15 * nights * students_N;
                }
            }

            else if (season == "Summer" && gender == "mixed")
            {
                sport = "Swimming";
                if (students_N >= 50)
                {
                    price += (20 * nights * students_N) - (20 * nights * students_N) * 0.50;
                }
                else if (students_N >= 20 && students_N < 50)
                {
                    price += (20 * nights * students_N) - (20 * nights * students_N) * 0.15;
                }
                else if (students_N >= 10 && students_N < 20)
                {
                    price += (20 * nights * students_N) - (20 * nights * students_N) * 0.05;
                }
                else
                {
                    price += 20 * nights * students_N;
                }
            }

            Console.WriteLine($"{sport} {price:F2} lv.");
        }
    }
}
