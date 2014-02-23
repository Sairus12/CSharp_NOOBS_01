using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Zaznam
    {
        public DateTime DatumCas { get; set; }
        public string JmenoZvirete { get; set; }
        public string Poznamka { get; set; }
        public int CisloZvirete { get; set; }

        public Zaznam(DateTime datumCas, int cisloZvirete, string jmenoZvirete, string poznamka)
        {
            DatumCas = datumCas;
            CisloZvirete = cisloZvirete;
            JmenoZvirete = jmenoZvirete;
            Poznamka = poznamka;
        }
        public override string ToString()
        {
            return "Datum\t\tČíslo zvířete\t\tJméno zvířete\t\tPoznámka\n" + DatumCas.ToShortDateString() + "\t" + CisloZvirete + "\t\t\t" + JmenoZvirete + "\t\t\t" + Poznamka;
        }
    }
}
