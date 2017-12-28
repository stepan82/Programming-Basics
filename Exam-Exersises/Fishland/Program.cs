using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceMakarell = double.Parse(Console.ReadLine());
            var priceCaca = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidi = int.Parse(Console.ReadLine());
            var palamudPrice = priceMakarell + (priceMakarell * 0.60);
            var pricePalamudFinal = kgPalamud * palamudPrice;
            var safridPrice = priceCaca + (priceCaca * 0.80);
            var priceSafridFinal = safridPrice * kgSafrid;
            var midiPrice = kgMidi * 7.50;
            var bill = midiPrice + priceSafridFinal + pricePalamudFinal;
            Console.WriteLine($"{bill:f2}");
        }
    }
}
