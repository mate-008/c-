using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        int[] dobasok = { 3, 1, 1, 2, 1, 5, 5, 4, 4, 4, 1, 2, 3, 6, 4, 6, 1, 4 };

        Console.WriteLine("2. feladat");

        int pozicio = 0;
        List<int> menet = new List<int>();
        int letralepesek = 0;

        foreach (int dobas in dobasok)
        {
            pozicio += dobas;


            if (pozicio >= 45)
            {
                menet.Add(pozicio);
                break;
            }


            if (pozicio % 10 == 0)
            {
                pozicio -= 3;
                letralepesek++;
            }

            menet.Add(pozicio);
        }


        Console.WriteLine(string.Join(" ", menet));


        Console.WriteLine("3. feladat");
        Console.WriteLine($"A játék során {letralepesek} alkalommal lépett létrára.");


        Console.WriteLine("4. feladat");
        if (pozicio >= 45)
            Console.WriteLine("A játékot befejezte.");
        else
            Console.WriteLine("A játékot abbahagyta.");
    }
}
