using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozeperettsegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] uvegek = { 5, 2, 2, 4, 3, 2, 4, 10, 5, 5, 3, 5, 4, 3, 3 };


            Console.WriteLine("2. feladat");
            Console.Write("Mari neni lekvarja (dl): ");
            int L = int.Parse(Console.ReadLine());


            int maxErtek = uvegek[0];
            int index = 0;
            for (int i = 1; i < uvegek.Length; i++)
            {
                if (uvegek[i] > maxErtek)
                {
                    maxErtek = uvegek[i];
                    index = i;
                }
            }

            Console.WriteLine("3. feladat");
            Console.WriteLine($"A legnagyobb uveg: {maxErtek} dl es {index + 1}. a sorban.");


            int osszKapacitas = 0;
            foreach (int uveg in uvegek)
            {
                osszKapacitas += uveg;
            }

            Console.WriteLine("4. feladat");
            if (osszKapacitas >= L)
            {
                Console.WriteLine("Elegendő uveg volt.");
            }
            else
            {
                Console.WriteLine("Maradt lekvar.");
            }
        }
    }
}