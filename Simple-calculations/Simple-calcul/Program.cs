using System;


namespace Simple_calcul
{
    class Program
    {
        static void Main(string[] args)
        {

            double dollars = double.Parse(Console.ReadLine());
            double levs = dollars * 1.79549;
            Console.WriteLine(Math.Round(levs, 2));
        }
    }
}