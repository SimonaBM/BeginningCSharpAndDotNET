using System;
using static System.Console;

namespace BooleanOperators
{
    internal class Program
    {
        
      {
            bool a = true;
            bool b = false;
            WriteLine($"AND | a | b ");
            WriteLine($"a | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR | a | b ");
            WriteLine($"a | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR | a | b ");
            WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} "); Console.WriteLine("Hello World!");
        }
    }
}
