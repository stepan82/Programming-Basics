using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var touristsOld = int.Parse(Console.ReadLine());
            var touristsStudents = int.Parse(Console.ReadLine());
            var sleepings = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var hotelSpend = sleepings * 82.99;
            if (transport == "train")
            {
                var transportSpend = (touristsOld * (24.99 * 2)) + (touristsStudents * (14.99 * 2));
                var comissionAgent = (transportSpend + hotelSpend) * 0.10;
                var totalSum = comissionAgent + hotelSpend + transportSpend;
                if ((touristsOld + touristsStudents) >= 50)
                {
                    var transportSpend_50 = (touristsOld * ((24.99 * 0.5) * 2)) + (touristsStudents * ((14.99 * 0.5) * 2));
                    var comissionAgent_50 = (transportSpend_50 + hotelSpend) * 0.10;
                    var totalSum_50 = comissionAgent_50 + hotelSpend + transportSpend_50;

                    Console.WriteLine(Math.Round(totalSum_50, 2));
                }
                else
                {
                    Console.WriteLine(Math.Round(totalSum, 2));
                }
            }
            else if (transport == "bus")
            {
                var transportSpend = (touristsOld * (32.50 * 2)) + (touristsStudents * (28.50 * 2));
                var comissionAgent = (transportSpend + hotelSpend) * 0.10;
                var totalSum = comissionAgent + hotelSpend + transportSpend;
                Console.WriteLine(Math.Round(totalSum, 2));
            }
            else if (transport == "boat")
            {
                var transportSpend = (touristsOld * (42.99 * 2)) + (touristsStudents * (39.99 * 2));
                var comissionAgent = (transportSpend + hotelSpend) * 0.10;
                var totalSum = comissionAgent + hotelSpend + transportSpend;
                Console.WriteLine(Math.Round(totalSum, 2));
            }
            else if (transport == "airplane")
            {
                var transportSpend = (touristsOld * (70.00 * 2)) + (touristsStudents * (50.00 * 2));
                var comissionAgent = (transportSpend + hotelSpend) * 0.10;
                var totalSum = comissionAgent + hotelSpend + transportSpend;
                Console.WriteLine(Math.Round(totalSum, 2));
            }
        }
    }
}
