using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var turns = int.Parse(Console.ReadLine());
            var total_0_9 = 0.0;
            var total_10_19 = 0.0;
            var total_20_29 = 0.0;
            var total_30_39 = 0.0;
            var total_40_50 = 0.0;
            var invalidNumber = 0.0;
            var total = 0.0;
            for (int i = 1; i <= turns; i++)
            {
                var n = int.Parse(Console.ReadLine());
                if (n >=0 && n < 10)
                {
                    total += n * 0.20;
                    total_0_9++;
                }
                else if (n>=10 && n<20)
                {
                    total += n * 0.30;
                    total_10_19++;
                }
                else if (n >= 20 && n < 30)
                {
                    total += n * 0.40;
                    total_20_29++;
                }
                else if (n >= 30 && n < 40)
                {
                    total += 50;
                    total_30_39++;
                }
                else if (n >= 40 && n <= 50)
                {
                    total += 100;
                    total_40_50++;
                }
                else if (n < 0 || n > 50)
                {
                    total /= 2;
                    invalidNumber++;
                }
            }

            
            var total_1 = (total_0_9 / turns) * 100;
            var total_2 = (total_10_19 / turns) * 100;
            var total_3 = (total_20_29 / turns) * 100;
            var total_4 = (total_30_39 / turns) * 100;
            var total_5 = (total_40_50 / turns) * 100;
            var total_6 = (invalidNumber / turns) * 100;


            Console.WriteLine($"{total:F2}");
            Console.WriteLine($"From 0 to 9: {total_1:F2}%");
            Console.WriteLine($"From 10 to 19: {total_2:F2}%");
            Console.WriteLine($"From 20 to 29: {total_3:F2}%");
            Console.WriteLine($"From 30 to 39: {total_4:F2}%");
            Console.WriteLine($"From 40 to 50: {total_5:F2}%");
            Console.WriteLine($"Invalid numbers: {total_6:F2}%");
        }
    }
}
