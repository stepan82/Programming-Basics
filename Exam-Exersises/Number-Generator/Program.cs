using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n_1 = int.Parse(Console.ReadLine());
            var n_2 = int.Parse(Console.ReadLine());
            var n_3 = int.Parse(Console.ReadLine());
            var specialNumber = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            string number = $"{n_1}{n_2}{n_3}";
            int numberOut = Convert.ToInt32(number);
            for (int i = numberOut; i >= 111; i-=10)
            {
                if (i % 3 == 0)
                {
                    specialNumber += 5;
                }
                else if (i % 10 == 5)
                {
                    specialNumber -= 2;
                }
                else if (i % 2 == 0)
                {
                    specialNumber *= 2;
                }

                if (specialNumber >= controlNumber && i >= 111)
                {
                    break;

                }
                else if (specialNumber < controlNumber && i == 111)
                {
                    break;
                }


            }

            if (specialNumber >= controlNumber)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");

            }

            else
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }


        }
    }
}
