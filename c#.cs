
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace projekt3
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Téglalap kerülete és területe");

            Console.Write("Kérem az a oldalt: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Kérem a b oldalt: ");
            double b = double.Parse(Console.ReadLine());

            double ker = 2 * a + 2 * b;
            double ter = a * b;

            Console.WriteLine("A kerület: " + ker);
            Console.WriteLine($"A terület: {ter}");

            if (ker == ter)
            {
                Console.WriteLine("Egyenlő");
            }
            else if (ker > ter)
            {
                Console.WriteLine("A kerület nagyobb");
            }
            else
            {
                Console.WriteLine("A terület nagyobb");
            }
            
            Random rnd = new Random();
            Console.WriteLine("Tanár diak kocka jatek");
            int tanar = rnd.Next(1, 6);
            Console.WriteLine($"a tanar {tanar} dobott!");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"a diak {diak} dobott!");
            if (tanar == diak)
            {
                Console.WriteLine("egyenlo");
            }
            else if (diak < tanar)
            {
                Console.WriteLine("A tanar ur nyert");
            }
            else
            {
                Console.WriteLine("Hát!!!");
            }
            

            for (int i = 1;i<= 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("hajra zte");
            }
            for (int i = 1;i <= 3 ; i++)
            {
                Console.WriteLine("fujpest");
            }
            string[] nevek = { "Anna", "Béla", "Csaba" };
             for (int i = 0; i < nevek.Length; i++)
                {
                    Console.WriteLine(nevek[1]);
                }
            string[] Nevek = { "Anna", "Béla", "Csaba" };
            foreach(string nev in Nevek)
            {
                Console.WriteLine(nev);
            }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }  while (i < 5);
            
            int[] szamok = { 12, 5, 8, -3, 15, 0}
            int.MaxValue min = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            Console.WriteLine("A legkisebb stám:" + min);

            int[] szamok = { 12, 5, 8, -3, 15, 0 }
            int min = szamok[0];
            foreach(int szam in szamok)
            {
                if (szam < min)
                {
                    min = szam;
                }
            }
            Console.WriteLine("a legkisebb szam:" + min);

            int[] szamok = { 12, 5, 8, -3, 15, 0 }
            int min = szamok[0];
            int i = 1;
            while (i < szamok.Length)
            {
                if (szamaok[i] < min) 
                {
                    min = szamok[i];
                }
            }
            Console.WriteLine("a legkisebb szam:" + min);ss
        }
    }
}
