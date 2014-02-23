using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozhrani
{
    class Jester: Zvire, IJester
    {
        public override void PresunSe()
        {
            Console.WriteLine("Plazim se....");
        }

        public void PlazSe()
        {
            Console.WriteLine("Plazim se...");
        }
    }
}
