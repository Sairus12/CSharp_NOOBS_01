using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Hra
    {
        private Lokace aktualniLokace;
        
        public Hra()
        {
            Lokace hrad = new Lokace("Hrad", "Překrásný hrad se zahradami.");
            Lokace les1 = new Lokace("Les", "Si v lese jako Hanzlík.");
            Lokace les2 = new Lokace("Les", "Pořád si v lese, tentokárt jako Hadraba.");
            Lokace les3 = new Lokace("Les", "Nekonečný les, kde je Toman a lesní panna.");
            Lokace les4 = new Lokace("Les", "Les vedoucí k domu.");
            Lokace dum = new Lokace("Dům", "Překrásný dům, který zavání airvickem.");
            Lokace plaz = new Lokace("Pláž", "Překrásná pláž s palmami.");

            hrad.vychod = les1;
            les1.vychod = les2;
            les1.zapad = hrad;
            les2.vychod = les3;
            les2.zapad = les1;
            les2.jih = les4;
            les3.vychod = plaz;
            les3.zapad = les2;
            les4.vychod = dum;
            les4.sever = les2;
            dum.zapad = les4;
            plaz.zapad = les3;

            aktualniLokace = dum;

        }

        public void Jdi(string kam)
        {
            kam.ToLower();
            if (kam.StartsWith("jdi"))
            {
                if (kam.Contains("sever") && (aktualniLokace.sever != null))
                {
                    aktualniLokace = aktualniLokace.sever;
                }
                else if (kam.Contains("jih") && (aktualniLokace.jih != null))
                {
                    aktualniLokace = aktualniLokace.jih;
                }
                else if (kam.Contains("zapad") && (aktualniLokace.zapad != null))
                {
                    aktualniLokace = aktualniLokace.zapad;
                }
                else if (kam.Contains("vychod") && (aktualniLokace.vychod != null))
                {
                    aktualniLokace = aktualniLokace.vychod;
                }
                else
                    Console.WriteLine("tam nemůžeš jít.");
            }
            else if (kam != "konec")
                Console.WriteLine("neznám tento příkaz.");
        }

        public Lokace VratAktualniLokaci()
        {
            return aktualniLokace;
        }
    }
}
