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
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var p_1 = 0.0;
            var p_2 = 0.0;
            var p_3 = 0.0;
            for (int i = 1; i <= numberOfNumbers; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if(number % 2 == 0 && number % 3 == 0 && number % 4 == 0)
                {
                    p_1 += 1;
                    p_2 += 1;
                    p_3 += 1;
                }
                else if (number % 2 == 0 && number % 3 == 0)
                {
                    p_1 += 1;
                    p_2 += 1;
                }
                else if (number % 2 == 0 && number % 4 == 0)
                {
                    p_1 += 1;
                    p_3 += 1;
                }
                else if (number % 3 == 0 && number % 4 == 0)
                {
                    p_2 += 1;
                    p_3 += 1;
                }
                else if(number % 2 == 0)
                {
                    p_1 += 1;
                }
                else if(number % 3 == 0)
                {
                    p_2 += 1;
                }
                else if(number % 4 == 0)
                {
                    p_3 += 1;                }
               
            }

            var totalP_1 = (p_1 / numberOfNumbers) * 100;
            var totalP_2 = (p_2 / numberOfNumbers) * 100;
            var totalP_3 = (p_3 / numberOfNumbers) * 100;

            Console.WriteLine($"{totalP_1:F2}%");
            Console.WriteLine($"{totalP_2:F2}%");
            Console.WriteLine($"{totalP_3:F2}%");

        }
    }
}
