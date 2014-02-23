using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozhrani
{
    class Delfin: Zvire
    {
        public void Vyskoc()
        {
            Console.WriteLine("Vyskočil jsem nad hladinu...");
        }

        public override void PresunSe()
        {
            Console.WriteLine("Plavu...");
        }
    }
}
