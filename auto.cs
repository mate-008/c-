using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace auto_file
{
    public class Auto
    {
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int Kilometer { get; set; }
        public string Szin { get; set; }
        public string Varos { get; set; }

        public Auto(string[] sor)
        {
            Marka = sor[0];
            Modell = sor[1];
            Evjarat = int.Parse(sor[2]);
            Kilometer = int.Parse(sor[3]);
            Szin = sor[4];
            Varos = sor[5];
        }

        public override string ToString()
        {
            return $"{Marka} {Modell} {Evjarat} {Kilometer} {Szin} {Varos}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>();

            string utvonal = @"C:\Felhasznalo1\Dokumentumok\auto\autok.txt";
            if (File.Exists(utvonal))
            {
                foreach (string sor in File.ReadLines(utvonal, Encoding.UTF8))
                {
                    autok.Add(new Auto(sor.Trim().Split('\t')));
                }
            }

            var rendezettLista = autok.OrderBy(a => a.Evjarat).ThenBy(a => a.Kilometer).ToList();

            int minEv = rendezettLista.Min(a => a.Evjarat);
            int maxEv = rendezettLista.Max(a => a.Evjarat);

            for (int i = minEv; i <= maxEv; i++)
            {
                Console.WriteLine($"\n{i}:");
                var eviAutok = rendezettLista.Where(a => a.Evjarat == i).ToList();
                for (int j = 0; j < eviAutok.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {eviAutok[j].Marka} {eviAutok[j].Modell}");
                }
            }

            Console.WriteLine("\nÖsszes kilométer évente:");
            for (int i = minEv; i <= maxEv; i++)
            {
                int osszKm = rendezettLista.Where(a => a.Evjarat == i).Sum(a => a.Kilometer);
                Console.WriteLine($"{i}: {osszKm} km");
            }

            Console.WriteLine("\nLegnagyobb futású autó 2015-ben:");
            var adottEv = rendezettLista.Where(a => a.Evjarat == 2015).ToList();
            if (adottEv.Any())
            {
                int maxKm = adottEv.Max(a => a.Kilometer);
                var legtobbetFutott = adottEv.Where(a => a.Kilometer == maxKm);
                foreach (var a in legtobbetFutott)
                {
                    Console.WriteLine($"{a.Marka} {a.Modell} {a.Kilometer} km");
                }
            }

            Console.ReadKey();
        }
    }
}