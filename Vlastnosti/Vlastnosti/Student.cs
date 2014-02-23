using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vlastnosti
{
    class Student
    {
        public string Jmeno { get; private set; }
        public bool Muz { get; private set; }
        public bool Plnolety { get; private set; }
        private int vek;

        public Student(string jmeno, bool pohlavi, int vek)
        {
            Jmeno = jmeno;
            Muz = pohlavi;
            this.vek = vek;
        }

        public override string ToString()
        {
            string jsemPlnolety = "jsem";
            if (!Plnolety)
                jsemPlnolety = "nejsem";
            string pohlavi = "muž";
            if (!Muz)
                pohlavi = "žena";
            return String.Format("Jsem {0}, {1}.  Je mi {2}  let a {3} plnoletý.", Jmeno, pohlavi, vek, jsemPlnolety);
        }
                
        public int Vek
        {
            get
            {
                return vek;
            }
            set
            {
                vek = value;
                Plnolety = true;
                if (vek < 18)
                    Plnolety = false;
            }
        }
    }
}
