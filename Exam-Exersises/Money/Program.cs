using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var chineseJoanes = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            var bitcoinsLeva = bitcoins * 1168;
            var chineseJoanesDollar = chineseJoanes * 0.15;
            var dollarsLeva = chineseJoanesDollar * 1.76;
            var prelimSum = (dollarsLeva + bitcoinsLeva) / 1.95;

            var sumComission = prelimSum - (prelimSum * (comission/100));
            Console.WriteLine(sumComission);
        }
    }
}
