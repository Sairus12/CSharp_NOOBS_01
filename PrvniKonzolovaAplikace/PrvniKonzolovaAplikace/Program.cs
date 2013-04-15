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

            /*
            Console.WriteLine("Právě zjistím počet možných pinů ke kreditním kartám...");
            int[] pin = new int[362880];
            for (int i = 0; i <= 9999; i++)
            {
                pin[i] = i;
                Console.WriteLine(pin[i]);
            }
            Console.ReadKey();
             */

            /*
            Console.WriteLine("Vítejte v kalkulačce");
            bool pokracovat = true;
            while (pokracovat)
            {
                Console.WriteLine("Zadejte první číslo:");
                float a;
                while (!float.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Neplatná volba, zadej znovu: ");

                Console.WriteLine("Zadejte druhé číslo:");
                float b;
                while (!float.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Neplatná volba, zadej znovu: ");

                Console.WriteLine("Zvolte si operaci:");
                Console.WriteLine("1 - sčítání");
                Console.WriteLine("2 - odčítání");
                Console.WriteLine("3 - násobení");
                Console.WriteLine("4 - dělení");

                char volba = Console.ReadKey().KeyChar;
                float vysledek = 0;
                bool platnaVolba = true;

                switch (volba)
                {
                    case '1' :
                        vysledek = a + b;
                        break;
                    case '2' :
                        vysledek = a - b;
                        break;
                    case '3' :
                        vysledek = a * b;
                        break;
                    case '4' :
                        vysledek = a / b;
                        break;

                    default :
                        platnaVolba = false;
                        break;
                }

                if (platnaVolba)
                    Console.WriteLine("\nVýsledek: {0}", vysledek);
                else
                    Console.WriteLine("\nNeplatná volba");

                Console.WriteLine("Přejete si zadat další příklad? [a/n]");
                platnaVolba = false;
                while (!platnaVolba)
                {
                    switch (Console.ReadKey().KeyChar.ToString().ToLower())
                    {
                        case "a":
                            {
                                pokracovat = true;
                                platnaVolba = true;
                                break;
                            }
                        case "n":
                            {
                                pokracovat = false;
                                platnaVolba = true;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nZadali jste špatnou volbu, eště raz [a/n]: ");
                                break;
                            }
                    }
                }
            }
            Console.WriteLine("\nDěkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
            Console.ReadKey();
            */



        }
    }
}