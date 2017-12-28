using System;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double convertCurrency = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            if (inputCurrency == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 1.79549, 2));
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 0.91801, 2));
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 0.70854, 2));
                }

            }

            if (inputCurrency == "BGN")
            {
                if (outputCurrency == "USD")
                {
                    Console.WriteLine(Math.Round(convertCurrency / 1.79549, 2));
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(convertCurrency / 1.95583, 2));
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine(Math.Round(convertCurrency / 2.53405, 2));
                }
            }

            if (inputCurrency == "EUR")
            {
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 2.53405, 2));
                }
                else if (outputCurrency == "USD")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 1.08930, 2));
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 0.77181, 2));
                }
            }

            if (inputCurrency == "GBP")
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 0.39462, 2));
                }
                else if (outputCurrency == "USD")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 2.53405 / 1.79549, 2));
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine(Math.Round(convertCurrency * 0.77181, 2));
                }
        }
    }
}