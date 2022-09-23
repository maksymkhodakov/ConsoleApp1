using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Converter
    {
        private static Dictionary<string, decimal> CurrencyDict= new Dictionary<string, decimal>();

        public Converter(string CurrencyName, decimal CurrencyCoefficient)
        {
            AddStat(CurrencyName, CurrencyCoefficient);
        }

        public static void AddStat(string CurrencyName, decimal CurrencyCoefficient)
        {
            if (CurrencyDict.ContainsKey(CurrencyName))
            {
                CurrencyDict[CurrencyName] = CurrencyCoefficient;
            }
            if (CurrencyCoefficient > 0)
            {
                CurrencyDict.Add(CurrencyName, CurrencyCoefficient);
            }
            else
            {
                Console.WriteLine("Dear User your coefficient is invalid!");
            }
        }

        public decimal ConvertCurrencyToHryvna(string currencyName, decimal currency) 
        {
            if (!CurrencyDict.ContainsKey(currencyName)) 
            {
                Console.WriteLine("There is no currency with this name in container right now!!!");
                return -1;
            }
            if (currency < 0) 
            {
                Console.WriteLine("Your input currency is less then 0");
                return -1;
            }
            return currency * CurrencyDict[currencyName];
        }

        public decimal ConvertHryvnaToCurrency(decimal hryvna, string toCurrency)
        {
            if (!CurrencyDict.ContainsKey(toCurrency))
            {
                Console.WriteLine("There is no currency with this name in container right now!!!");
                return -1;
            }
            if (hryvna < 0)
            {
                Console.WriteLine("Your input hryvnas is less then 0");
                return -1;
            }
            return hryvna / CurrencyDict[toCurrency];
        }
    }
}
