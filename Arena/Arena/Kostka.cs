using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    /// <summary>
    /// Třída reprezentuje hrací kostku
    /// </summary>
    class Kostka
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int pocetSten;
        /// <summary>
        /// Kostka, kde parametr je počet stěn kostky
        /// </summary>
        /// <param name="pocetSten">Počet stěn</param>
        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }
        /// <summary>
        /// Kostka s pevně daným počtem stěn (6)
        /// </summary>
        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }
        /// <summary>
        /// Vrací počet stěn
        /// </summary>
        /// <returns>Vrací počet stěn</returns>
        public int VratPocetSten()
        {
            return pocetSten;
        }
        /// <summary>
        /// Hození kostkou
        /// </summary>
        /// <returns>Vrací číslo od 1 do počtu stěn</returns>
        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }
        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami.",pocetSten);
        }
    }
}
