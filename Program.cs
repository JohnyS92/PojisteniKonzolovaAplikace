using System;
using System.Collections.Generic;
using System.Linq;

namespace PojisteniApp
{

    class Program
    {
        static void Main(string[] args)
        {
            // Instance pojišťovny
            Pojistovna pojistovna= new Pojistovna();

            bool pokracovat = true;

            // Hlavní cyklus programu
            while (pokracovat)
            {
                Console.WriteLine("Vyberte možnost:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného podle jména a přijmení");
                Console.WriteLine("4 - Ukončit program\n");

                int volba;
                while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 4)
                {
                    Console.WriteLine("Neplatná volba, zvolte znovu.");
                }

                // Reakce na volbu
                switch (volba)
                {
                    case 1:
                        pojistovna.PridejPojisteneho();
                        Console.WriteLine();
                        break;
                    case 2:
                        pojistovna.VypisPojistenych();
                        Console.WriteLine();
                        break;
                    case 3:
                        pojistovna.VyhledavejPojisteneho();
                        Console.WriteLine();
                        break;
                    case 4:
                        pokracovat = false;
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                }
                Console.ReadKey();
            }
        }        
    }
}