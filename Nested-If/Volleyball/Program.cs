using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var holydaysOther = int.Parse(Console.ReadLine());
            var holydaysHome = int.Parse(Console.ReadLine());
            var saturdaysPLayings = (48 - holydaysHome) * (3.0 / 4.0);
            var playingsSofia = holydaysOther * (2.0 / 3.0);
            var playingsTotal = saturdaysPLayings + playingsSofia + holydaysHome;
            var playingTotalLeap = playingsTotal + (playingsTotal * 0.15);
            if (yearType == "leap")
            {
                Console.WriteLine(Math.Truncate(playingTotalLeap));
            }
            else
            {
                Console.WriteLine(Math.Truncate(playingsTotal));
            }
        }
    }
}
