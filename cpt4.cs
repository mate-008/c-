using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int> { 1,2,3,4,5,6,7};
            List<int> parosszamok = new List<int>();

            foreach (int szam in szamok)
            { if (szam % 2 == 0)
                {
                    parosszamok.Add(szam);
                }

            }
            Console.WriteLine("2-vel oszthato szamok: "+ string.Join(", ", parosszamok));


            Console.WriteLine("Adj meg egy szamot (1-7): ");
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
                    Console.WriteLine("Nincs ilyen nap");
            }
        }
    }
}
