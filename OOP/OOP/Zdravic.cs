using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    /// <summary>
    /// Třída představuje zdravič, který nám pozdraví uživatele.
    /// </summary>
    class Zdravic
    {
        /// <summary>
        /// Text pozdravu
        /// </summary>
        public string text;
        /// <summary>
        /// Pozdraví uživatele zadaným textem a jeho jménem
        /// </summary>
        /// <param name="jmeno"></param>
        public void Pozdrav(string jmeno)
        {
            Console.WriteLine("{0} {1}",text,jmeno);
        }
        /// <summary>
        /// Pozdraví uživatale zadaným textem a jeho jménem - vrací jako string
        /// </summary>
        /// <param name="jmeno">Jméno uživatele</param>
        /// <returns>Text s pozdravem</returns>
        public string Pozdravv(string jmeno)
        {
            return String.Format("{0} {1}", text, jmeno);
        }
    }
}
