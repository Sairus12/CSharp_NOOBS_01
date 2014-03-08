using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------------------Kalkulačka
            Kalkulacka kalk = new Kalkulacka();
            Console.WriteLine("Zadej prvni cislo:  ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhe cislo: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Součet: {0}", kalk.scitani(a, b));
            Console.WriteLine("Odečet a-b: {0}", kalk.odcitani(a, b, 1));
            Console.WriteLine("Odečet b-a: {0}", kalk.odcitani(a, b, 2));
            Console.WriteLine("Nasobeni: {0}", kalk.nasobeni(a, b));
            Console.WriteLine("Dělení a/b: {0}", kalk.deleni(a, b, 1));
            Console.WriteLine("Dělení b/a: {0}", kalk.deleni(a, b, 2));
            */

            /* ------------------------------Nakladak
            Nakladak vw = new Nakladak();
            vw.Naloz(10000);
            vw.Naloz(500);
            vw.Vyloz(300);
            vw.Vyloz(1000);
            */

            /* ------------------------------Kamarádi
            Kamaradi[] clovek = new Kamaradi[2];
            //Kamaradi clovek1 = new Kamaradi(Console.ReadLine(), int.Parse(Console.ReadLine()));
            //Kamaradi clovek2 = new Kamaradi(Console.ReadLine(), int.Parse(Console.ReadLine()));
            for (int i = 0; i < 2 ; i++)
                clovek[i] = new Kamaradi(Console.ReadLine(), int.Parse(Console.ReadLine()));
            clovek[0].PridejKamarada(clovek[1]);
            clovek[1].PridejKamarada(clovek[0]);
            clovek[0].PredstavSe();
            clovek[1].PredstavSe();
            */

            /* ------------------------------Únava
            Unava clovek = new Unava("Jan Tlumič");
            clovek.Bez(10);
            clovek.Bez(10);
            clovek.Bez(10);
            clovek.Spi(1);
            clovek.Bez(10);
            */
            
            /* ------------------------------Generátor vět
            GeneratorVet[] gen = new GeneratorVet[10];
            int i=0;
            Random rand = new Random();
            for (i = 0; i < 10; i++)
            {
                gen[i] = new GeneratorVet();
                Console.WriteLine(gen[i].VygenerujVetu(rand));
            }
            */

            /* ------------------------------Garáž
            Auto auto = new Auto(Console.ReadLine(),Console.ReadLine());
            Garaz garaz = new Garaz();
            garaz.Zaparkuj(auto);
            garaz.Vypis();
            */

            /* ------------------------ Psi
            Clovek karel = new Clovek("Karel Novák");
            Clovek lenka = new Clovek("Lenka Nováková");
            Pes azor = new Pes(1,"Azor");
            karel.pes = azor;
            lenka.pes = azor;
            Console.WriteLine(azor);
            // Zestárnutí psa
            karel.pes.Zestarni();
            lenka.pes.Zestarni();
            // Kontrolní výpis psa
            Console.WriteLine(azor);
            */

            /* ------------------------ Hra
            Hra hra = new Hra();
            string prikaz = "";

            while (prikaz.ToLower() != "konec")
            {
                Console.WriteLine(hra.VratAktualniLokaci());
                Console.Write("Zadej příkaz: ");
                prikaz = Console.ReadLine();
                hra.Jdi(prikaz);
            }
            */


            Console.ReadKey();
        }
    }
}
