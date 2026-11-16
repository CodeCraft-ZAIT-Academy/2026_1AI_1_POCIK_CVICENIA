
using System;
using System.Collections.Generic;

namespace Dú_knižnica_16._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kniha> kniznica = new List<Kniha>();

            kniznica.Add(new Kniha("Harry Potter a Kameň mudrcov", "Fantasy", 8));
            kniznica.Add(new Kniha("Harry Potter a Tajomná komnata", "Fantasy", 15));
            kniznica.Add(new Kniha("Pán prsteňov: Spoločenstvo prsteňa", "Fantasy", 18));
            kniznica.Add(new Kniha("Malý princ", "Fantasy", 6));
            kniznica.Add(new Kniha("Hra o tróny", "Fantasy", 18));
            kniznica.Add(new Kniha("Rozprávky Pavla Dobšinského", "Rozprávky", 3));
            kniznica.Add(new Kniha("Denník odvážneho bojka 1", "Humor", 12));
            kniznica.Add(new Kniha("Poklad na Bobrej rieke", "Dobrodružné", 13));





            while (true)
            {
                Console.WriteLine("Knižnica");


                foreach (var Item in kniznica)
                {
                    Console.WriteLine($"Názov: {Item.Nazov}, Žáner: {Item.Zaner}, Veková kategória: {Item.VekovaKategoria}");
                }



                Console.WriteLine("Zadajte názov knihy/exit:");
                string knihaIndex = Console.ReadLine();

                if (knihaIndex == "exit")
                {
                    break;
                }


                Console.WriteLine("Zadaj žáner knihy:");
                string zanerIndex = Console.ReadLine();
                Console.WriteLine("Zadaj vekovú kategóriu 3, 8, 15, 18:");
                int vek = int.Parse(Console.ReadLine());
                if (vek == 3 || vek == 8 || vek == 15 || vek == 18)
                {
                    kniznica.Add(new Kniha(knihaIndex, zanerIndex, vek));
                    Console.WriteLine("Kniha bola úspešne pridaná");
                }
                else
                {
                    Console.WriteLine("Zle zadaná veková kategória. Skús znova.");
                }
            }
        }
    }
}
