using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statika
{
    class Uzivatel
    {
        private string jmeno;
        private string heslo;
        private bool prihlaseny;
        private int id;

        public static int minimalniDelkaHesla = 6;
        public static int dalsiId = 1;

        public Uzivatel(string jmeno, string heslo)
        {
            this.jmeno = jmeno;
            this.heslo = heslo;
            prihlaseny = false;
            id = dalsiId;
            dalsiId++;
        }
        public bool PrihlasSe(string zadaneHeslo)
        {
            if (zadaneHeslo == heslo)
            {
                prihlaseny = true;
                return true;
            }
            else
                return false;
        }
        public static bool ZvalidujHeslo(string heslo)
        {
            if ((heslo.Length >= minimalniDelkaHesla))
                return true;
            else
                return false;
        }
        public int VratId()
        {
            return id;
        }
        public static int VratMinimalniDelkuHesla()
        {
            return minimalniDelkaHesla;
        }

    }
}
