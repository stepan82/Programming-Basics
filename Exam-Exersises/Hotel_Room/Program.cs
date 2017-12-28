using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var sleepings = int.Parse(Console.ReadLine());
            if(month == "May" || month == "October")
            {
                var studioPrice = sleepings * 50;
                var apartmentPrice = sleepings * 65;
                if (sleepings > 7 && sleepings <= 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", sleepings * (50 - (50 * 0.05)));
                }
                else if (sleepings > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", sleepings * (65 - (65 * 0.1)));
                    Console.WriteLine("Studio: {0:F2} lv.", sleepings * (50 - (50 * 0.3)));
                }
                else if(sleepings <= 7)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
                }
            }

            if (month == "June" || month == "September")
            {
                var studioPrice = sleepings * 75.20;
                var apartmentPrice = sleepings * 68.70;
                if (sleepings > 14)
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", sleepings * (68.70 - (68.70 * 0.1)));
                    Console.WriteLine("Studio: {0:F2} lv.", sleepings * (75.20 - (75.20 * 0.2)));
                }
                else if(sleepings <= 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
                }
            }
          

            if (month == "July" || month == "August")
            {
                var studioPrice = sleepings * 76;
                var apartmentPrice = sleepings * 77;
                if (sleepings > 14)
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", sleepings * (77 - (77 * 0.1)));
                    Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
                }
            }   
        }
    }
}
