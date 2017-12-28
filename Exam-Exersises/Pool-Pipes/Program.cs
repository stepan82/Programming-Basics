using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumePool = int.Parse(Console.ReadLine());
            var pipe_1Debit = int.Parse(Console.ReadLine());
            var pipe_2Debit = int.Parse(Console.ReadLine());
            var hoursMissing = double.Parse(Console.ReadLine());
            var totalPipe_1Debit = pipe_1Debit * hoursMissing;
            var totalPipe_2Debit = pipe_2Debit * hoursMissing;
            var totalDebit = totalPipe_1Debit + totalPipe_2Debit;
            if (totalDebit > volumePool)
            {
                Console.WriteLine($"For {hoursMissing} hours the pool overflows with {totalDebit-volumePool:F1} liters.");
            }
            else if(totalDebit<=volumePool)
            {
                var totalPercent = Math.Floor((totalDebit * 100) / volumePool);
                var percentPipe_1 = Math.Floor((totalPipe_1Debit * 100) / totalDebit);
                var percentPipe_2 = Math.Floor((totalPipe_2Debit * 100) / totalDebit);
                Console.WriteLine($"The pool is {totalPercent}% full. Pipe 1: {percentPipe_1:F0}%. Pipe 2: {percentPipe_2:F0}%.");
            }
        }
    }
}
