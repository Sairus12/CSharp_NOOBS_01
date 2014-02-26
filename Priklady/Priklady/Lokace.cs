using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Lokace
    {
        /// <summary>
        /// Název lokace.
        /// </summary>
        private string nazev;
        /// <summary>
        /// Popis lokace.
        /// </summary>
        private string popis;
        /// <summary>
        /// Severní lokace.
        /// </summary>
        public Lokace sever;
        /// <summary>
        /// Východní lokace.
        /// </summary>
        public Lokace vychod;
        /// <summary>
        /// Jižní lokace.
        /// </summary>
        public Lokace jih;
        /// <summary>
        /// Z8padní lokace.
        /// </summary>
        public Lokace zapad;

        /// <summary>
        /// Objekt Lokace.
        /// </summary>
        /// <param name="nazev">Název lokace.</param>
        /// <param name="popis">Popis lokace.</param>
        public Lokace(string nazev, string popis)
        {
            this.nazev = nazev;
            this.popis = popis;
        }

        public override string  ToString()
        {
            string vystup = nazev + "\n";
            vystup += popis + "\n\n";
            string smery = "";
            if (sever != null)
                smery += "sever ";
            if (jih != null)
                smery += "jih ";
            if (zapad != null)
                smery += "západ ";
            if (vychod != null)
                smery += "východ ";
            if (smery != null)
                vystup += "Můžeš jít na " + smery + "\n";
            return vystup;
        }

    }
}
