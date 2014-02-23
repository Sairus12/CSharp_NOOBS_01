using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    /// <summary>
    /// Třída dědí z třídy Bojovník a přidává metody a fce s manou
    /// </summary>
    class Mag: Bojovnik
    {
        /// <summary>
        /// Aktuální mana
        /// </summary>
        private int mana;
        /// <summary>
        /// Maximální mana
        /// </summary>
        private int maxMana;
        /// <summary>
        /// Magický útok
        /// </summary>
        private int magickyUtok;
        /// <summary>
        /// Konstruktor, který zajišťuje rozšířenou verzi bojovníka - Mága
        /// </summary>
        /// <param name="jmeno">Jméno mága</param>
        /// <param name="zivot">Počet životů</param>
        /// <param name="utok">Síla útoku</param>
        /// <param name="obrana">Velikost obrany</param>
        /// <param name="kostka">Používaná kostka</param>
        /// <param name="mana">Počet many</param>
        /// <param name="magickyUtok">Síla magického útoku</param>
        public Mag(string jmeno, int zivot, int utok, int obrana, Kostka kostka, int mana, int magickyUtok)
            : base(jmeno, zivot, utok, obrana, kostka)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magickyUtok = magickyUtok;
        }
        /// <summary>
        /// Metoda, která vykoná útok na zadaného soupeře
        /// </summary>
        /// <param name="souper">Soupeř, na kterého se bude útočit</param>
        public override void Utoc(Bojovnik souper)
        {
            // Mana není naplněna
            if (mana < maxMana)
            {
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                base.Utoc(souper);
            }
            else // Magický útok
            {
                int uder = magickyUtok + kostka.hod();
                NastavZpravu(String.Format("{0} použil magii za {1} hp", jmeno, uder));
                souper.BranSe(uder);
                mana = 0;
            }
            
        }
        public string GrafickaMana()
        {
            return GrafickyUkazatel(mana, maxMana);
        }
        

    }
}
