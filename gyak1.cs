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

                
            Console.WriteLine("1. feladat: Kérem adja meg a heti atkivitast(max 250 karakter):");
            string aktivitas = Console.ReadLine();

            //2. feladat
            int osszKm = 0;
            bool voltU = false, voltG = false, voltF = false, voltK = false;

            foreach (char c in aktivitas)
            {
                switch (c)
                {
                    case 'U': osszKm += 1; voltU = true; break;
                    case 'G': osszKm += 1; voltG = true; break;
                    case 'F': osszKm += 2; voltF = true; break;
                    case 'K': osszKm += 10; voltK = true; break;
                }
            }
            Console.WriteLine("2. feladat: A felhasznalo altal megtett tavolsag: (0) km", osszKm);

            //+.feladat
            int jutalom = 0;
            if (voltu && voltG &&  voltF && voltK)
            {
                jutalom = 10;
                Console.WriteLine("3. feladat: bravo! jutalma meg 10km");

            }
            else
            {
                Console.WriteLine("3. feladat: nem jar jutalom");
            }


            //4. feladat
            int vegsoKm = osszKm + jutalom;
            Console.WriteLine("4. feladat: osszteljesitmeny: (0) km", vegsoKm);

            if (vegsoKm >= 40)
            {
                Console.WriteLine("gratulalok, kihivas teljesitve");
            }

             static void kiirat()
 {
     Console.WriteLine("Hello Premo!");
 }
 static void Main(string[] args)
 { kiirat(); }

 static void kiirat(string nev)
 {
     Console.WriteLine(nev + "Hello" );
 }

 static void Main(string[] args)
 {
     kiirat("Timi ");
     kiirat("Tamás ");
 }
 static void kiirat(string nev, int kor)
 { Console.WriteLine(nev + "hello" + kor + "eves"); }

 static void Main(string[string] args)
 {
     kiirat("Timi",20)
     kiirat("Kata", 30)
 }

 static void main(string iskola="Premo")
 {
     Console.WriteLine("Hello" +iskola);
 }

 static void Main(string[] args)
 {
     kiirat();
     kiirat("Vajda");
     kiirat();
     kiirat("VsZK");
 }
 static void szamol()
 { Console.WriteLine("kerem a negyzet oldalat");
     int szam = int.Parse(Console.ReadLine());
     Console.WriteLine("a negyzet terulete:" + szam * szam);
 }

 static void Main(string[] args)
 {
     szamol();
 }

 static int szamol()
 {
     Console.WriteLine("kerem a negyzet oldalat:");
     int szam = int.Parse(Console.ReadLine());
     int ter = szam * szam;
     return ter;
 }

 static void Main(string[] args)
 {
     Console.WriteLine(" a negyzet terulete:" + szamol());
 }
        }
    }
}


static void Main(string[] args)
{

    List<List<object>> automata = new List<List<object>>();
    string file1 = @"C:\Premo\Asztali_alkalmazasok_fejlesztese\automata\automata.txt";

    foreach (string sor in File.ReadLines(file1))
    {
        string[] darabok = sor.Trim().Split(';');

        List<object> adatsor = new List<object>();

        adatsor.Add(int.Parse(darabok[0]));
        adatsor.Add(int.Parse(darabok[1]));
        adatsor.Add(int.Parse(darabok[2]));
        adatsor.Add(int.Parse(darabok[3]));
        adatsor.Add(darabok[4]);

        automata.Add(adatsor);
    }

    foreach (var sor in automata)
    {
        Console.WriteLine(string.Join(" ", sor));
    }

    // # 1 feladat Határozd meg hány fajta termék van az automatában!

    Console.WriteLine($"Az automatában {automata.Count} féle termék van!");

    // # 2 feladat Írasd ki, hogy milyen termékek vannak!

    for (int i = 0; i < automata.Count; i++)
    {
        Console.WriteLine(automata[i][4]);
    }

    // # 3 feladat Határozd meg hánydarab termék van

    int db = 0;

    for (int i1 = 0; i1 < automata.Count; i1++)
    {
        db = db + (int)automata[i1][0];
    }

    Console.WriteLine(db);


    // # 4 feladat Határozd meg min

    int min1 = (int)automata[0][0];

    for (int i1 = 0; i1 < automata.Count; i1++)
    {
        if (min1 > (int)automata[i1][0])
        {
            min1 = (int)automata[i1][0];
        }
    }

    Console.WriteLine(min1);

}

