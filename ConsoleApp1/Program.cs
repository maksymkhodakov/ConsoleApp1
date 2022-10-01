using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            string number = Console.ReadLine();
            if (double.TryParse(number, out double num))
            {
                Console.WriteLine("You entered :" + num);
            }
        }
    }
}
