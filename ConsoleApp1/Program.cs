using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("本日!");
            SchoolGetter c1 = new SchoolGetter();
            c1.GetHTML();
        }
    }
}

