using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Garaz
    {
        private Auto auto;

        public void Zaparkuj(Auto auto)
        {
            this.auto = auto;
        }
        public void Vypis()
        {
            Console.WriteLine("Zaparkovane auto je:  {0}",auto.VratSpz());
        }
    }
}
