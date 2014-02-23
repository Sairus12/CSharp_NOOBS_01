using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Uzivatel
    {
        /// <summary>
        /// Jméno zaměstnance
        /// </summary>
        public string Jmeno { get; set; }
        /// <summary>
        /// Příjmení zaměstnance
        /// </summary>
        public string Prijmeni { get; set; }
        /// <summary>
        /// Věk uživatele
        /// </summary>
        public int Vek { get; set; }
        /// <summary>
        /// Číslo zaměstnance
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Konstruktor pro vytvoření universálního uživatele se základními údaji
        /// </summary>
        /// <param name="jmeno">Jméno uživatele</param>
        /// <param name="prijmeni">Příjmení uživatele</param>
        /// <param name="vek">Věk uživatele</param>
        /// <param name="id">Číslo zaměstatnce/0 pro návštěvníka</param>
        public Uzivatel(string jmeno, string prijmeni, int vek, int id)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Id = id;
        }
        
        public override string ToString()
        {
            return String.Format("{0} {1}",Jmeno,Prijmeni);
        }
    }
}
