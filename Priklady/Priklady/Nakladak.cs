using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Nakladak
    {
        private int nosnost;
        private int aktualniNaklad = 0;
        public Nakladak(int nosnost)
        {
            this.nosnost = nosnost;
        }
        public Nakladak()
        {
            nosnost = 3000;
        }
        public void Naloz(int naklad)
        {
            if (aktualniNaklad + naklad <= nosnost)
                Console.WriteLine("Naložili ste náklad o hmostnosti {0}kg a náklad má nyní {1}kg.", naklad, (aktualniNaklad += naklad));
            else
                Console.WriteLine("Nelze naložit náklad o hmotnosti {0}kg, nosnost {1}kg by byla překročena o {2}kg.", naklad, nosnost, (aktualniNaklad + naklad) - nosnost);
        }
        public void Vyloz(int naklad)
        {
            if ((aktualniNaklad - naklad) > 0)
                Console.WriteLine("Vyložili ste náklad o hmostnosti {0}kg a náklad má nyní {1}kg.", naklad, (aktualniNaklad -= naklad));
            else
                Console.WriteLine("Nelze vyložit náklad o hmotnosti {0}kg, nosnost {1}kg by byla podkročena o {2}kg.", naklad, nosnost, -(aktualniNaklad - naklad));
        }
    }
}
