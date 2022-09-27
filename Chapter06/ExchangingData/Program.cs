using System;

namespace ExchangingData
{
    internal class Program
    {
        static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");
        }
        static void Main(string[] args)
        {
            int val = 5;
            Console.WriteLine($"val = {val}");
            ShowDouble(ref val);
            Console.WriteLine($"val = {val}");
            Console.ReadLine();
        }

        struct CustomerName
        {
            public string firstName, lastName;
            public string fullName => $"{firstName} {lastName}";
         

        }

    }
}


