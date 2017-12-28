using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n_1 = int.Parse(Console.ReadLine());
            var n_2 = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            if (sign == "+")
            {
                if ((n_1 + n_2) % 2 == 0)
                {
                    Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 + n_2} - even");
                }
                else
                {
                    Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 + n_2} - odd");
                }
               
            }
            else if (sign == "-")
            {
                if ((n_1 - n_2) % 2 == 0)
                {
                    Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 - n_2} - even");
                }
                else
                {
                    Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 - n_2} - odd");
                }

            }
            else if (sign == "*")
            {
                if ((n_1 * n_2) % 2 == 0)
                {
                    Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 * n_2} - even");
                }
                else
                {
                    Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 * n_2} - odd");
                }
            }

            else if ((sign == "/" || sign == "%") && n_2 == 0)
            {
                Console.WriteLine($"Cannot divide {n_1} by zero");
            }

            else if (sign == "/")
            {
                double n = Convert.ToDouble(n_1);
                double nn = Convert.ToDouble(n_2);
                Console.WriteLine($"{n_1} {sign} {n_2} = {n / nn:F2}");
            }

            else if (sign == "%")
            {
                Console.WriteLine($"{n_1} {sign} {n_2} = {n_1 % n_2}");
            }

          
        }
    }
}
