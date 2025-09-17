using System;

namespace projekt3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Téglalap kerülete és területe
            Console.WriteLine("Téglalap kerülete és területe");

            Console.Write("Kérem az a oldalt: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Kérem a b oldalt: ");
            double b = double.Parse(Console.ReadLine());

            double ker = 2 * (a + b);
            double ter = a * b;

            Console.WriteLine("A kerület: " + ker);
            Console.WriteLine($"A terület: {ter}");

            if (ker == ter)
                Console.WriteLine("Egyenlő");
            else if (ker > ter)
                Console.WriteLine("A kerület nagyobb");
            else
                Console.WriteLine("A terület nagyobb");

            // Tanár-diák kockajáték
            Random rnd = new Random();
            Console.WriteLine("\nTanár-diák kockajáték");
            int tanar = rnd.Next(1, 7);
            Console.WriteLine($"A tanár {tanar}-t dobott!");
            int diak = rnd.Next(1, 7);
            Console.WriteLine($"A diák {diak}-t dobott!");

            if (tanar == diak)
                Console.WriteLine("Egyenlő");
            else if (diak < tanar)
                Console.WriteLine("A tanár úr nyert");
            else
                Console.WriteLine("A diák nyert!");

            // Számlálások és ismétlések
            Console.WriteLine("\nSzámlálás 1-től 5-ig:");
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i);

            Console.WriteLine("\nHajrá ZTE!");
            for (int i = 1; i <= 5; i++)
                Console.WriteLine("Hajrá ZTE");

            Console.WriteLine("\nFújpest:");
            for (int i = 1; i <= 3; i++)
                Console.WriteLine("Fújpest");

            // Nevek kiírása
            string[] nevek = { "Anna", "Béla", "Csaba" };
            Console.WriteLine("\nNevek for ciklussal:");
            for (int i = 0; i < nevek.Length; i++)
                Console.WriteLine(nevek[i]);

            Console.WriteLine("\nNevek foreach ciklussal:");
            foreach (string nev in nevek)
                Console.WriteLine(nev);

            // while ciklus
            Console.WriteLine("\nSzámlálás while ciklussal:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            // do-while ciklus
            Console.WriteLine("\nSzámlálás do-while ciklussal:");
            j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);

            // Legkisebb szám keresése többféle ciklussal
            int[] szamok = { 12, 5, 8, -3, 15, 0 };

            // for ciklus
            int min = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                    min = szamok[i];
            }
            Console.WriteLine("\nA legkisebb szám (for): " + min);

            // foreach ciklus
            min = szamok[0];
            foreach (int szam in szamok)
            {
                if (szam < min)
                    min = szam;
            }
            Console.WriteLine("A legkisebb szám (foreach): " + min);

            // while ciklus
            min = szamok[0];
            int k = 1;
            while (k < szamok.Length)
            {
                if (szamok[k] < min)
                    min = szamok[k];
                k++;
            }
            Console.WriteLine("A legkisebb szám (while): " + min);

            // do-while ciklus
            min = szamok[0];
            k = 1;
            do
            {
                if (szamok[k] < min)
                    min = szamok[k];
                k++;
            } while (k < szamok.Length);
            Console.WriteLine("A legkisebb szám (do-while): " + min);
        }
    }
}

