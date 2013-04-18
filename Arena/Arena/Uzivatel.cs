using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    class Uzivatel
    {
        public int vek;
        public string jmeno;

        public Uzivatel(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }
        public override string ToString()
        {
            return (jmeno);
        }
    }
}
