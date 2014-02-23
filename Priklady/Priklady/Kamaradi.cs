using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Kamaradi
    {
        private string jmeno;
        private int vek;
        Kamaradi kamarad;


        public Kamaradi(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }
        public void PredstavSe()
        {
            Console.WriteLine("Ahoj, jmenuji se {0}, je mi {1}let a můj kamarád je {2}.", jmeno, vek, kamarad.jmeno);
        }
        public void PridejKamarada(Kamaradi kamarad)
        {
            this.kamarad = kamarad;
        }
    }
}
