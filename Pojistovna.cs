using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojisteniApp
{
    class Pojistovna
    {
        /// <summary>
        /// List pojištěných osob
        /// </summary>
        List<Osoba> seznamPojistenych = new List<Osoba>();

        /// <summary>
        /// Přidání pojištěného
        /// </summary>
        public void PridejPojisteneho()
        {
            // Zadání jména
            Console.WriteLine("Zadejte jméno:");
            string jmeno = Console.ReadLine();

            // Ověření, že uživatel zadal hodnotu
            while (string.IsNullOrWhiteSpace(jmeno))
            {
                Console.WriteLine("Jméno pojištěného nemůže být prázdné. Zadejte prosím znovu:");
                jmeno = Console.ReadLine();
            }

            // Zadání přijmení
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();

            // Ověření, že uživatel zadal hodnotu
            while (string.IsNullOrWhiteSpace(prijmeni))
            {
                Console.WriteLine("Příjmení pojištěného nemůže být prázdné. Zadejte prosím znovu:");
                prijmeni = Console.ReadLine();
            }

            // Zadání telefonu
            Console.WriteLine("Zadejte telefon:");
            string telefon = Console.ReadLine();

            // Ověření, že uživatel zadal hodnotu
            while (string.IsNullOrWhiteSpace(telefon))
            {
                Console.WriteLine("Telefon pojištěného nemůže být prázdný. Zadejte prosím znovu:");
                telefon = Console.ReadLine();
            }

            // Zadání věku uživatele
            Console.WriteLine("Zadejte věk:");
            int vek;
            // Ověření, že uživatel zadal správnou hodnotu
            while (!int.TryParse(Console.ReadLine(), out vek) || vek <= 0)
            {
                Console.WriteLine("Věk musí být celé kladné číslo. Zadejte prosím znovu:");
            }

            // Přidání instance osoby do listu
            seznamPojistenych.Add(new Osoba(jmeno, prijmeni, telefon, vek));

            Console.WriteLine("Pojištěný byl úspěšně přidán.\nPokračuj libovolnou klávesou...");
        }

        /// <summary>
        /// Výpis pojištěných osob
        /// </summary>
        public void VypisPojistenych()
        {
            // Podmínka na ověření zda jsou nějaké osoby v databázi
            if (seznamPojistenych.Count == 0)
            {
                Console.WriteLine("Seznam pojištěných je prázdný.");
            }
            else
            {
                Console.WriteLine("Seznam pojištěných osob:");
                foreach (Osoba osoba in seznamPojistenych)
                {
                    // Návratová hodnota z třídy Osoba metodou ToString
                    Console.WriteLine(osoba.ToString());
                }
            }
            Console.WriteLine("Pokračuj libovolnou klávesou...");
        }

        /// <summary>
        /// Vyhledání pojištěné osoby v listu
        /// </summary>
        public void VyhledavejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine();

            Osoba nalezeny = null;

            // Cyklus na nalezení osob
            foreach (Osoba osoba in seznamPojistenych)
            {
                if (osoba.Jmeno == jmeno && osoba.Prijmeni == prijmeni)
                {
                    nalezeny = osoba;
                    break;
                }
            }

            // Podmínka pro případ, že se daná osoba v listu nenachází.
            if (nalezeny == null)
            {
                Console.WriteLine("Pojištěný s tímto jménem a příjmením nebyl nalezen.");
            }
            else
            {
                Console.WriteLine("Pojištěný nalezen:");
                Console.WriteLine("  Jméno a příjmení: {0} {1}", nalezeny.Jmeno, nalezeny.Prijmeni);
                Console.WriteLine("  Telefon: {0}", nalezeny.Telefon);
                Console.WriteLine("  Věk: {0}", nalezeny.Vek);
                Console.WriteLine("Pokračuj libovolnou klávesou...");
            }
        }
    }
}

