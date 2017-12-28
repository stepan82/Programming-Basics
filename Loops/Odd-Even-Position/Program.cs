using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = double.Parse(Console.ReadLine());
            var oddTotal = 0.0;
            var oddMin = 1000000000.0;
            var oddMax = -1000000000.0;
            var evenTotal = 0.0;
            var evenMin = 1000000000.0;
            var evenMax = -1000000000.0;
            for (double i = 1; i <= numberOfNumbers; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if(i % 2 != 0)
                {
                    oddTotal += number;
                    if(number > oddMax && number < oddMin)
                    {
                        oddMax = number;
                        oddMin = number;
                    }
                    else if(number > oddMax)
                    {
                        oddMax = number;
                    }
                    else if(number < oddMin)
                    {
                        oddMin = number;
                    }
                }


                if (i % 2 == 0)
                {
                    evenTotal += number;
                    if (number > evenMax && number < evenMin)
                    {
                        evenMax = number;
                        evenMin = number;
                    }
                    else if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    else if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
            }


            if (oddMax == -1000000000.0 && oddMin == 1000000000.0 && evenMax == -1000000000.0 && evenMin == 1000000000.0)
            {
                Console.WriteLine($"OddSum={oddTotal}");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum={evenTotal}");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
            }
            else if (oddMax == -1000000000.0 && oddMin == 1000000000.0)  
            {

                Console.WriteLine($"OddSum={oddTotal}");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum={evenTotal}");
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else if (evenMax == -1000000000.0 && evenMin == 1000000000.0)
            {
                Console.WriteLine($"OddSum={oddTotal}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenTotal}");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
            }
         
            else
            {
                Console.WriteLine($"OddSum={oddTotal}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenTotal}");
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");
            }
        }
    }
}
