using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Pes
    {
        private int vek;
        private string jmeno;
        public Pes(int vek, string jmeno)
        {
            this.vek = vek;
            this.jmeno = jmeno;
        }
        public void Zestarni()
        {
            vek++;
        }
        public override string ToString()
        {
            return "Pes " + jmeno + " má " + vek.ToString() + " let";
        }
    }
}
