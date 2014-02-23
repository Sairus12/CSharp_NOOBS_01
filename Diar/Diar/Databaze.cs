using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diar
{
    class Databaze
    {
        private List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }
        /// <summary>
        /// Přidá záznamy
        /// </summary>
        /// <param name="datumCas">Datum, které se vztahuje k události</param>
        /// <param name="text">Obsah, který se vztahuje k onu datu</param>
        public void PridejZaznam(DateTime datumCas, string text)
        {
            zaznamy.Add(new Zaznam(datumCas, text));
        }
        /// <summary>
        /// Najde záznamy podle zadaného data a případně i času
        /// </summary>
        /// <param name="datum">Datum, ke kterému se budou hledat záznamy</param>
        /// <param name="dleCasu">Zda se bude hledat i podle času</param>
        /// <returns>Vrací nalezné záznamy</returns>
        public List<Zaznam> NajdiZaznamy(DateTime datum, bool dleCasu)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if ((dleCasu) && (datum == z.DatumCas) //dle času a data
                ||
                ((!dleCasu) && (z.DatumCas.Date == datum.Date))) // pouze dle data
                    nalezene.Add(z);
            }
            return nalezene;
        }
        /// <summary>
        /// Vymaže záznamy z daného data
        /// </summary>
        /// <param name="datum">K zadanému datu se najdou záznamy a pokud existují, vymažou se</param>
        public void VymazZaznamy(DateTime datum)
        {
            List<Zaznam> nalezeno = NajdiZaznamy(datum, true);
            foreach (Zaznam z in zaznamy)
                zaznamy.Remove(z);
        }
    }
}
