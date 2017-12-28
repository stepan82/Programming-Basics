using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair
{
    class Program
    {
        static void Main(string[] args)
        {
            var sitePlayground = int.Parse(Console.ReadLine());
            var widePlochka = double.Parse(Console.ReadLine());
            var longPlocka = double.Parse(Console.ReadLine());
            var widePeika = int.Parse(Console.ReadLine());
            var longPeika = int.Parse(Console.ReadLine());
            var squarePlayground = sitePlayground * sitePlayground;
            var squarePeika = widePeika * longPeika;
            var squarePlochka = widePlochka * longPlocka;
            var totalPlochki = (squarePlayground - squarePeika) / squarePlochka;
            var totalTime = totalPlochki * 0.2;
            Console.WriteLine("{0:F2}", totalPlochki);
            Console.WriteLine("{0:F2}", totalTime);
        }
    }
}
