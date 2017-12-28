using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var treated = 0;
            var untreated = 0;
            var doctors = 7;
            for (int i = 1; i <= period; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && treated < untreated)
                {
                    if (patients <= doctors)
                    {
                        doctors++;
                        treated += patients;
                    }
                    else if (patients == doctors)
                    {
                        doctors++;
                        treated += doctors;
                    }
                    else if (patients > doctors)
                    {
                        doctors++;
                        untreated += patients - doctors;
                        treated += doctors;
                    }
                }
                else if(patients == doctors)
                {
                    treated += doctors;
                }
                else if (patients < doctors)
                {
                    treated += patients;
                }
                else if (patients > doctors)
                {
                    untreated += patients - doctors;
                    treated += doctors;
                }  
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
