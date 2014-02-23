using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozhrani
{
    class Program
    {
        static void Main(string[] args)
        {
            IPtak ptak = new Ptak();
            ptak.Dychej();
            PtakoJester ptakojester = new PtakoJester();
            ptakojester.PlazSe();

            Ptak n = new Ptak();
            n.Klovni();
            

            IPtak ptakk = new PtakoJester();
            ptakk.Pipni();
            ((PtakoJester)ptakk).PlazSe();
            
            IPtak ptakkk = new PtakoJester();
            ptakkk.Dychej();
            IJester jester = new PtakoJester();
            jester.Dychej();
            
            
            List<Zvire> zvirata = new List<Zvire>();
            zvirata.Add(new Ptak() { Vaha = 1 });
            zvirata.Add(new Delfin() { Vaha = 8 });
            zvirata.Add(new Delfin() { Vaha = 9 });
            zvirata.Add(new PtakoJester() { Vaha = 3 });
            zvirata.Add(new PtakoJester() { Vaha = 2 });

            zvirata.Sort();
            foreach (Zvire z in zvirata)
                Console.WriteLine(z);
            foreach (Zvire zvire in zvirata)
            {
                Console.WriteLine(zvire);
                zvire.Dychej();
                if (zvire is Delfin)
                    ((Delfin)zvire).Vyskoc();

                if (zvire is Delfin)
                    (zvire as Delfin).Vyskoc();

                if (zvire.GetType() == typeof(Delfin))
                    (zvire as Delfin).Vyskoc();
            }

            Jester jeste = new Jester { Vaha = 5 };
            Ptak pta = new Ptak { Vaha = 1 };
            Delfin delfi = new Delfin { Vaha = 10 };
            Console.WriteLine("Křížím {0} a {1}", jeste, pta);
            Zvire krizenec1 = jeste + pta;
            Console.WriteLine("Výsledkem je {0} s váhou {1}", krizenec1, krizenec1.Vaha);

            Console.WriteLine("Křížím {0} a {1}", jeste, delfi);
            Zvire krizenec2 = jeste + delfi;
            Console.WriteLine("Výsledkem je {0}", krizenec2);
            Console.ReadKey();
        }
    }
}
