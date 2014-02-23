using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diar
{
    class Diar
    {
        private Databaze databaze;

        public Diar()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Načte od uživatele datum
        /// </summary>
        /// <returns>Vrací datum k dalšímu zpracování</returns>
        private DateTime ZjistiDatumCas()
        {
            Console.WriteLine("Zadejte datum a čas ve tvaru [1.1.2012 14:00]:");
            DateTime datumCas;
            while (!DateTime.TryParse(Console.ReadLine(), out datumCas))
                Console.WriteLine("Chybné zadání, zadejte znovu datum a čas: ");
            return datumCas;
        }
        /// <summary>
        /// Vypíše záznamy, které se vztahuji k zadnému dni
        /// </summary>
        /// <param name="den">Den, ke kterému se budou hledat záznamy</param>
        public void VypisZaznamy(DateTime den)
        {
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(den, false);
            foreach (Zaznam z in zaznamy)
                Console.WriteLine(z);
        }
        /// <summary>
        /// Přidá záznam k aktuálnímu datu, text zadá uživatel
        /// </summary>
        public void PridejZaznam()
        {
            DateTime datumCas = ZjistiDatumCas();
            Console.WriteLine("Zadejte text záznamu: ");
            string text = Console.ReadLine();
            databaze.PridejZaznam(datumCas, text);
        }
        public void VyhledejZaznamy()
        {
            // Zadání data uživatelem
            DateTime datum = ZjistiDatumCas();
            // Vyhledávání záznamů
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(datum, false);
            // Výpis záznamů
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }
        public void VymazZáznamy()
        {
            Console.WriteLine("Budou vymazány záznamy v daný den a hodinu");
            DateTime datum = ZjistiDatumCas();
            databaze.VymazZaznamy(datum);
        }
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("Vítejte v diáři!");
            Console.WriteLine("Dnes je: {0}", DateTime.Now);
            Console.WriteLine();
            // výpis hlavní obrazovky
            Console.WriteLine("Dnes:\n-----");
            VypisZaznamy(DateTime.Today);
            Console.WriteLine("Zítra:\n-----");
            VypisZaznamy(DateTime.Now.AddDays(1));
            Console.WriteLine();
        }
    }
}
