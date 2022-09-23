using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Converter converter = new Converter("USD", 36.5M);
            Console.WriteLine(converter.ConvertCurrencyToHryvna("USD", 350));
            Console.WriteLine(converter.ConvertHryvnaToCurrency(13000M, "USD"));

            Converter.AddStat("EU", 36.5M);
            Console.WriteLine(converter.ConvertCurrencyToHryvna("EU", 350));
            Console.WriteLine(converter.ConvertHryvnaToCurrency(13000M, "EU"));
        }
    }
}
