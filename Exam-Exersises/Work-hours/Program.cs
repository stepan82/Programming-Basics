using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());
            var workingTime = workers * (workingDays * 8);
            if (workingTime >= hoursNeeded)
            {
                Console.WriteLine($"{workingTime - hoursNeeded} hours left");
            }
            else
            {
                Console.WriteLine($"{hoursNeeded - workingTime} overtime");
                Console.WriteLine($"Penalties: {(hoursNeeded - workingTime) * workingDays}");
            }
        }
    }
}
