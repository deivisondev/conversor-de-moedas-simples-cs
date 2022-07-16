namespace SimpleCurrencyConverter
{
    public class CurrencyConverter
    {
        public static double Iof = 6.0 / 100;
        public static double ConvertToDollar(double dollarQuote, double valueInDollar)
        {
            double valueInReal = dollarQuote * valueInDollar;

            return valueInReal + (valueInReal * Iof);
        }
    }
}
