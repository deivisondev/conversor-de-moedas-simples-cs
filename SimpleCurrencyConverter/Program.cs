using System;
using System.Globalization;

namespace SimpleCurrencyConverter
{
    class Program
    {
        static void Main()
        {
            Console.Write("Qual a cotação do dólar? ");
            double dollarQuote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double valueInDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {CurrencyConverter.ConvertToDollar(dollarQuote, valueInDollar).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
