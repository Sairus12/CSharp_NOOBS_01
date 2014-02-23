using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozhrani
{
    class Ptak: Zvire, IPtak
    {
        public void Pipni()
        {
            Console.WriteLine("♫ ♫ ♫");
        }
        public void Klovni()
        {
            Console.WriteLine("Klov, Klov!");
        }

        public override void PresunSe()
        {
            Console.WriteLine("Letím...");
        }
    }
}
