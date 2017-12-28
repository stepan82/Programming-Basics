using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonsPlayer_1 = int.Parse(Console.ReadLine());
            var pokemonsPlayer_2 = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());
            var currentBattles = 0;
            for (int first = 1; first <= pokemonsPlayer_1; first++)
            {
                for (int second = 1; second <= pokemonsPlayer_2; second++)
                {
                    Console.Write($"({first} <-> {second}) ");
                    currentBattles++;
                    if (currentBattles == maxBattles)
                    {
                        break;
                    }
                }
                if (currentBattles == maxBattles)
                {
                    break;
                }
            }
        }
    }
}
