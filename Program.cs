using System;
using System.Collections.Generic;

namespace bombc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] == keresett)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i}. indexen.");
                    megtalalva = true;
                    break;
                }
            }

            if (!megtalalva)
            {
                Console.WriteLine($"A {keresett} szám nincs a listában.");
            }
            
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;
            int index = 0;

            foreach (int szam in szamok)
            {
                if (szam == keresett)
                {
                    Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {index}. indexen.");
                    megtalalva = true;
                    break;
                }
                index++;
            }

            if (!megtalalva)
            {
                Console.Writeline($"A keresett szám ({keresett}) megtalálva a(z) {i}. indexen.")
            }
            
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;
            bool megtalalva = false;
            int i = 0;

            if (szamok.Count > 0)
            {
                do
                {
                    if (szamok[i] == keresett)
                    {
                        Console.WriteLine($"A keresett szám ({keresett}) megtalálva a(z) {i}. indexen.");
                        megtalalva = true;
                        break;
                    }
                    i++;
                } while (i < szamok.Count);
            }

            if (!megtalalva)
            {
                Console.Writeline($"a {keresett} szam nincs a listaban");
            }
            
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;

            if (szamok.Contains(keresett))
            {
                Console.WriteLine($"A keresett szám ({keresett}) megtalálva a listaban.");
            }
            else
            {
                Console.WriteLine($"a {keresett} szam nincs a listaban");
            }
            */
            List<int> szamok = new List<int> { 4, 8, 15, 16, 23, 42 };
            int keresett = 16;

            int index = szamok.IndexOf(keresett);

            if (index != -1)
            {
                Console.WriteLine($"a ({keresett}) szam megtalalva a {index} indexen ");
            }
            else
            {
                Console.WriteLine($"a {keresett} szam nincs a listaban");
            }
        }
    }
}