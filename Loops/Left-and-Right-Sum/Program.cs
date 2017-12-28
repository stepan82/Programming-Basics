using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var enteredNumbers = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 1; i <= enteredNumbers; i++)
            {
                var number = int.Parse(Console.ReadLine());
                leftSum = leftSum + number;
            
            }

            for (int i = 1; i <= enteredNumbers; i++)
            {
                var number = int.Parse(Console.ReadLine());
                rightSum = rightSum + number;
            }

            if(leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }

        }
    }
}
