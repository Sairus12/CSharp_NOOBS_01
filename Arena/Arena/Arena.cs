using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Arena
{
    /// <summary>
    /// Třída, která představuje arénu
    /// </summary>
    class Arena
    {
        /// <summary>
        /// První bojovník
        /// </summary>
        private Bojovnik bojovnik1;
        /// <summary>
        /// Druhý bojovník
        /// </summary>
        private Bojovnik bojovnik2;
        /// <summary>
        /// Kostka, kterou se bude házet
        /// </summary>
        private Kostka kostka;
        /// <summary>
        /// Vytvoření nové arény
        /// </summary>
        /// <param name="bojovnik1">První bojovník</param>
        /// <param name="bojovnik2">Druhý bojovník</param>
        /// <param name="kostka">Kostka, kterou se bude házet</param>
        public Arena(Bojovnik bojovnik1, Bojovnik bojovnik2, Kostka kostka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kostka = kostka;
        }
        /// <summary>
        /// Vypisuje "HUD" ve "hře"
        /// </summary>
        private void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("------------ Aréna ------------ \n");
            Console.WriteLine("Bojovníci: \n");
            VypisBojovnika(bojovnik1);
            Console.WriteLine();
            VypisBojovnika(bojovnik2);
            Console.WriteLine();
        }
        /// <summary>
        /// Vypisuje zprávy
        /// </summary>
        /// <param name="zprava">Zpráva, která bude vypsána</param>
        private void VypisZpravu(string zprava)
        {
            Console.WriteLine(zprava);
            Thread.Sleep(500);
        }
        /// <summary>
        /// Hlavní metoda (fce), tedy zápas
        /// </summary>
        public void Zapas()
        {
            // původní pořadí
            Bojovnik b1 = bojovnik1;
            Bojovnik b2 = bojovnik2;
            Console.WriteLine("Vítej v aréně!");
            Console.WriteLine("Dnes se utkají {0} a {1}! \n", bojovnik1, bojovnik2);
            // prohození bojovníků
            bool zacinaBojovnik2 = (kostka.hod() <= kostka.VratPocetSten() / 2);
            if (zacinaBojovnik2)
            {
                b1 = bojovnik2;
                b2 = bojovnik1;
            }
            Console.WriteLine("Začínat bude bojovník {0}! \nZápas může začít...", b1);
            Console.ReadKey();
            // cyklus s bojem
            while (b1.Nazivu() && b2.Nazivu())
            {
                b1.Utoc(b2);
                Vykresli();
                VypisZpravu(b1.VratPosledniZpravu());  // zpráva o útoku
                VypisZpravu(b2.VratPosledniZpravu());  // zpráva o obraně

                if (b2.Nazivu())
                {
                    b2.Utoc(b1);
                    Vykresli();
                    VypisZpravu(b2.VratPosledniZpravu());  // zpráva o útoku
                    VypisZpravu(b1.VratPosledniZpravu());  // zpráva o obraně
                }
             
                Console.WriteLine();
            }
        }
        private void VypisBojovnika(Bojovnik b)
        {
            Console.WriteLine(b);
            Console.Write("Život: ");
            Console.WriteLine(b.GrafickyZivot());
            if (b is Mag)
            {
                Console.Write("Mana: ");
                Console.WriteLine(((Mag)b).GrafickaMana());
            }
        }
            
        
    }
}
