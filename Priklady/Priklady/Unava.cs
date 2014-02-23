using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Unava
    {
        private string jmeno;
        private int unava = 0;

        public Unava(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public void Bez(int km)
        {
            if ((unava + km) <= 20)
                unava += km;
            else
                Console.WriteLine("Nelze již běžet. Jsem příliš unavený.");
        }
        public void Spi(int hodin)
        {
            if ((unava - (10 * hodin)) >= 0)
                unava -= (10 * hodin);
        }
    }
}
