using System;
using System.Collections.Generic;
using System.IO;

namespace vroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Teljes elérési út
            string filePath = @"C:\Users\user\Downloads\auto.txt";

            // Fájl soronkénti beolvasása
            List<string> sorok = new List<string>(File.ReadAllLines(filePath));

            // Teszt kiíratása
            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
            }
        }
    }
}
