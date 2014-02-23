using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    /// <summary>
    /// Třída, která představuje bojovníka a jeho metody
    /// </summary>
    class Bojovnik
    {
        /// <summary>
        /// Jméno bojovníka
        /// </summary>
        protected string jmeno;
        /// <summary>
        /// Život v HP
        /// </summary>
        protected int zivot;
        /// <summary>
        /// Maximální ždraví
        /// </summary>
        protected int maxZivot;
        /// <summary>
        /// Útok v HP
        /// </summary>
        protected int utok;
        /// <summary>
        /// Obrana v HP
        /// </summary>
        protected int obrana;
        /// <summary>
        /// Instance hrací kostky
        /// </summary>
        protected Kostka kostka;
        /// <summary>
        /// Zpráva o aktuálním dění
        /// </summary>
        private string zprava;

        /// <summary>
        /// Instance objektu bojovník
        /// </summary>
        /// <param name="jmeno">Jméno bojovníka</param>
        /// <param name="zivot">Počet životů (zároveň max životy)</param>
        /// <param name="utok">Síla útok</param>
        /// <param name="obrana">Velikost obrany</param>
        /// <param name="kostka">Kostka, kterou se bude házet</param>
        public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kostka = kostka;
        }
        /// <summary>
        /// Vypíše jméno bojovníka
        /// </summary>
        /// <returns>Vrací jméno bojovníka</returns>
        public override string ToString()
        {
            return jmeno;
        }
        /// <summary>
        /// vypisuje jestli bojovník žije
        /// </summary>
        /// <returns>Vrací jestli bojovník žije</returns>
        public bool Nazivu()
        {
            return (zivot > 0);
        }
        /// <summary>
        /// Vypisuje graficky, kolik má bojovník životů
        /// </summary>
        /// <returns>Vrací grafické znázornění životů</returns>
        protected string GrafickyUkazatel(int aktualni, int maximalni)
        {
            string s = "";
            int celkem = 20;
            double pocet = Math.Round(((double)aktualni/maximalni)  * celkem);

            if ((pocet == 0) && (Nazivu()))
                pocet = 1;

            for (int i = 0; i < pocet; i++)
                s += "█";

            s = s.PadRight(celkem + 1);
            s += String.Format(" {0}",aktualni);
            return s;
        }
        /// <summary>
        /// Ukazuje aktuální život graficky
        /// </summary>
        /// <returns>Výslednou grafickou podobu</returns>
        public string GrafickyZivot()
        {
            return GrafickyUkazatel(zivot, maxZivot);
        }
        /// <summary>
        /// Vyhodnotí útok s obranou a vrátí výsledný život
        /// </summary>
        /// <param name="uder">Síla útoku v HP</param>
        public void BranSe(int uder)
        {
            int zraneni = uder - (obrana + kostka.hod());
            if (zraneni > 0)
            {
                zivot -= zraneni;
                zprava = String.Format("{0} utrpěl poškození {1} hp", jmeno, zraneni);
                if (zivot <= 0)
                {
                    zivot = 0;
                    zprava += " a zemřel";
                }
            }
            else
                zprava = String.Format("{0} odrazil útok",jmeno);
        }
        /// <summary>
        /// Zaútočí na daného soupeře
        /// </summary>
        /// <param name="souper">Bojovník, na kterého útočíme</param>
        public virtual void Utoc(Bojovnik souper)
        {
            int uder = utok + kostka.hod();
            NastavZpravu(String.Format("{0} útočí s úderem za {1} hp",jmeno,uder));
            souper.BranSe(uder);
        }
        /// <summary>
        /// Nastavuje zprávu, kterou budeme vypisovat v metodě VratPosledniZpravu()
        /// </summary>
        /// <param name="zprava">Zpráva</param>
        protected void NastavZpravu(string zprava)
        {
            this.zprava = zprava;
        }
        /// <summary>
        /// Vrací konečnou zprávu
        /// </summary>
        /// <returns>Vrací konečnou zprávu</returns>
        public string VratPosledniZpravu()
        {
            return zprava;
        }

            

    }
}
