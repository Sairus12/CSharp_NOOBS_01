using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrvniKonzolovaAplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            /* float x, y;
            Console.WriteLine("Ahoj Světe.");
            Console.WriteLine("Ahoj, jsem papoušek Manťák pes.  Napiš něco a já to zopakuji: ");
            string s;
            s = Console.ReadLine();
            Console.WriteLine(s + " " + s);

            Console.WriteLine("Vítej v kalkulačce.\nZadejte dvě čísla, se kterými budou vykonány základní matematické operace: ");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            float scitani = x + y;
            float odcitani = x - y;
            float nasobeni = x * y;
            float deleni = x / y;
            Console.WriteLine("Vysledek  sčítání: " + scitani);
            Console.WriteLine("Vysledek  odčítání: " + odcitani);
            Console.WriteLine("Vysledek  násobení: " + nasobeni);
            Console.WriteLine("Vysledek  dělení: " + deleni);
            Console.ReadKey(); */

            /***********************************************************************************************************************************/

            /* Console.WriteLine("Právě nechám zjistit všechny piny creditních karet na světě....");
            int i = 0;
            int[] pin = new int[i];

            for (i = 0; i <= 9999; i++)
                pin[i] = i;
             */

            /* string s = "Krokonosohroch";
            Console.WriteLine(s);
            Console.WriteLine(s.StartsWith("krok"));
            Console.WriteLine(s.EndsWith("hroch"));
            Console.WriteLine(s.Contains("nos"));
            Console.WriteLine(s.Contains("roh"));
            Console.ReadKey(); */

            /* string s = "FullScrEEn sHaDowS AutoSaVe";
            s = s.ToLower();

            Console.WriteLine("Poběží hra ve fullscreenu ?");
            Console.WriteLine(s.Contains("fullscreen"));
            Console.WriteLine("Budou ve hře zapnuté stíny ?");
            Console.WriteLine(s.Contains("shadows"));
            Console.WriteLine("Budou ve hře vypnuté zvuky ?");
            Console.WriteLine(s.Contains("nosound"));
            Console.WriteLine("Bude ve hře zapnutý autosave?");
            Console.WriteLine(s.Contains("autosave"));
            Console.ReadKey(); */


            /* Console.WriteLine("Zadej číslo: ");
            string x = Console.ReadLine();

            Console.WriteLine("Napsal jste tento text: " + x);
            Console.WriteLine("Text po funkci Trim(): " + x.Trim());
            int a = int.Parse(x);
            Console.WriteLine("Převedl jsem zadaný text na číslo parsováním, zadal jste: " + a);
            Console.ReadKey(); */


            Console.WriteLine("Právě zjistím počet možných pinů ke kreditním kartám...");
            int[] pin = new int[362880];
            for (int i = 0; i <= 9999; i++)
            {
                pin[i] = i;
                Console.WriteLine(pin[i]);
            }
            Console.ReadKey();

        }
    }
}