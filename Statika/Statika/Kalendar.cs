using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statika
{
    class Kalendar
    {
        public string VratNastaveni()
        {
            string s = "";
            s += String.Format("Jazyk: {0}\n", Nastaveni.Jazyk());
            s += String.Format("Barevné schéma: {0}\n", Nastaveni.BarevneSchema());
            s += String.Format("Spustit po startu: {0}\n", Nastaveni.SpustitPoStartu());
            return s;
        }
    }
}
