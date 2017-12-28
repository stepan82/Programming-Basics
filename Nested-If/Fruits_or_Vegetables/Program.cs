using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits_or_Vegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = Console.ReadLine();
           
            if(thing == "banana" || thing == "apple" || thing == "kiwi" || thing == "cherry" || thing == "lemon" || thing == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if(thing == "tomato" || thing == "cucumber" || thing == "pepper" || thing == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
