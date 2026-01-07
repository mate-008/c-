using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Négyzet kerülete");
            Console.WriteLine("kérem az a oldalt");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a kerulet:");
            Console.WriteLine(4 * a);
            Console.WriteLine("a terulet: ");
            Console.WriteLine(a * a);
            

            Console.WriteLine("Teglalap kerulete es terulete:");
            Console.WriteLine("kerem az a oldalt");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("kerem a b oldalt:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("a kerulet:" + 2 * a + 2 * b);
            double ker = 2 * a + 2 * b;
            double ter = a * b;
            Console.WriteLine($"a terulet {ter}");
            
            if (ker == ter)
            {
                Console.WriteLine("Tegyenlo:");
            }
            else if ( ker == ter)
            { 
                Console.WriteLine("a kerulet nagyobb mint a terulet")
              }
            else
            {
                    Console.WriteLine("a terulet nagyobb")
             }
             
            
            Random rnd = new Random();
            Console.WriteLine("tanar diak kocka jatek");
            int tanar = rnd.Next(1, 6);
            Console.WriteLine($"a tanar {tanar} dobott:");
            int diak = rnd.Next(1, 6);
            Console.WriteLine($"a diak {diak} dobott:");
            if (tanar == diak)
            {
                Console.WriteLine("egyenlo");
            }
            else if (tanar > diak)
            { 
                Console.WriteLine("a tanar nyert");
            }
            else
            {
                Console.WriteLine("a dak nyert");
            }
            
            
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; 1 <= 5; i++)
            {
                Console.WriteLine("hajra ZTE");
            }

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("fujpest");
            }


            string[] nevek = { "anna", "bela", "csaba" };
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            string[] nevek = { "anna", "bela", "csaba" };
            foreach (string nev in nevek)
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
            } while (i < 5);

            

            int[] szamok = { 1, 2, 3, 4, -5, 6 };
            int min = szamok[0];

            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }

            foreach (int szam in szamok)
            {
                if (szam < min)
                {
                    min = szam;
                }
            }
            Console.WriteLine("a legkisebb szam: " + min);

            

            int i = 1;
            while (i < szamok.Length)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            }
            Console.WriteLine("a legkisebb szam: " + min);

            

            int[] szamok = { 1, 2, 3, 4, -5, 6 };
            int min = szamok[0];
            int i = 1;
            do
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
                i++;
            }
            while (i < szamok.Length);
            Console.WriteLine("a legkisebb szam: " + min);

            int min szamok.Min();
            Console.WriteLine($"a legkisebb szam: {min}");
            */

            
            List<int> szamok = new List<int> { 1, 2, 4, 6, 8, 3, 7, 5 };
            List<int> paros = new List<int>();

            foreach (int szam in szamok)
            {
                if (szam % 2 == 0)
                {
                    paros.Add(szam);

                }
            }
            Console.WriteLine("2-vel oszthato szamok: " + string.Join(", ", paros));

            Console.Write("adj meg egy szamot (1-7):");
            int nap = int.Parse(Console.ReadLine());
            switch (nap)
            {
                case 1:
                    Console.WriteLine("Hetfo");
                    break;

                case 2:
                    Console.WriteLine("Kedd");
                    break;

                case 3:
                    Console.WriteLine("Szerda");
                    break;

                case 4:
                    Console.WriteLine("Csutortok");
                    break;

                case 5:
                    Console.WriteLine("Pentek");
                    break;

                case 6:
                    Console.WriteLine("Szombat");
                    break;

                case 7:
                    Console.WriteLine("Vasarnap");
                    break;

                default:
                    Console.WriteLine("nincs ilyen nap");
                    break;
        }
    }
}

