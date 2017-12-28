using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {    
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ivalid number");
                }  
            }
            Console.WriteLine(n);
        }
    }
}
