using System;


namespace OveroadingFuntions
{
    internal class Program
    {

    }
 }

static int ShowDouble(int val)
{
    Console.WriteLine($"double val {val * 2}");
    return val * 2;
}
static void ShowDouble(int val, out int doubled)
{
    doubled = val * 2;
}
static void ShowDouble(string val)
{
    int res1 = Convert.tiInt32(val) * 2;
    Console.WriteLine($"doubled val {res}");

}

