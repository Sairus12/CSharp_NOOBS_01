using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vlastnosti
{
    class Student
    {
        public string jmeno;
        public bool muz;
        public int vek;
        public bool plnolety;

        public Student(string jmeno, bool pohlavi, int vek)
        {
            this.jmeno = jmeno;
            this.muz = pohlavi;
            this.vek = vek;
            if (vek <= 18)
                plnolety = false;
        }

        public override string ToString()
        {
            string jsemPlnolety = "jsem";
            if (!plnolety)
                jsemPlnolety = "nejsem";
            string pohlavi = "muž";
            if (!muz)
                pohlavi = "žena";
            return String.Format("Jsem {0}, {1}. Je mi {2} let a {3} plnolety.", jmeno, pohlavi, vek, jsemPlnolety);
        }
    }
}
