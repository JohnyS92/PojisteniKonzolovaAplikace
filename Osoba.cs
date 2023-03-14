using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojisteniApp
{
    /// <summary>
    /// Osoba v naší pojišťovně
    /// </summary>
    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Telefon { get; set; }
        public int Vek { get; set; }
        /// <summary>
        /// Vytvoření nové reprezentace pojištěné osoby 
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="telefon"></param>
        /// <param name="vek"></param>
        public Osoba(string jmeno, string prijmeni, string telefon, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Vek = vek;
        }
        /// <summary>
        /// Návratová reprezentace osoby
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Jméno a přijmení: {Jmeno} {Prijmeni}, Tel: {Telefon}, Věk: {Vek}";
        }
    }
}
