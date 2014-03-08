using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Osoba
    {
        public Osoba otec;
        public Osoba matka;
        private string jmeno;

        public Osoba(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public void PridejRodice(Osoba otec, Osoba matka)
        {
            this.otec = otec;
            this.matka = matka;
        }
        public override string ToString()
        {
            return jmeno;
        }
    }
}
