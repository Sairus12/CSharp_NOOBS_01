using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozhrani
{
    class PtakoJester: Zvire, IPtak, IJester
    {
        public void Pipni()
        {
            Console.WriteLine("♫ ♫ ♫♫ ♫ ♫");
        }


        public void PlazSe()
        {
            Console.WriteLine("Plazím se....");
        }

        public override void PresunSe()
        {
            Console.WriteLine("Letím...");
        }
    }
}
