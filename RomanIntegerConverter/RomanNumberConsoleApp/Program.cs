using RomanIntegerConverter.Model;
using System;

namespace RomanNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                RomanInteger x;
                Console.WriteLine("Gib eine Ganzzahl ein:");
                x = Int32.Parse(Console.ReadLine());
                if (x >= 5000)
                    Console.WriteLine("Achtung: Römische zahlen über 5000 können nicht in UTF8 dargestellt werden");
                Console.WriteLine("Die römische Zahl ist: {0}", x.GetRomanNumber());
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
