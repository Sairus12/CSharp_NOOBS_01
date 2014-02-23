using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Databaze
    {
        public List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejZaznam(int cisloZvirete, string jmenoZvirete, string poznamka)
        {
            zaznamy.Add(new Zaznam(DateTime.Now, cisloZvirete, jmenoZvirete, poznamka));
        }
        public List<Zaznam> NajdiZaznamy(int cisloZvirete)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if (cisloZvirete == z.CisloZvirete)
                    nalezene.Add(z);
            }
            return nalezene;
        }
        public void VymazZaznamy(int cisloZvirete)
        {
            List<Zaznam> nalezeno = NajdiZaznamy(cisloZvirete);
            foreach (Zaznam z in nalezeno)
                zaznamy.Remove(z);
        }
    }
}
