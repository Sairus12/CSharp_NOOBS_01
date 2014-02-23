using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Losovani_Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            Losovac losovac = new Losovac();
            List<string> poradi = new List<string>();
            poradi.Add("Prvni");
            Console.WriteLine(poradi[0]);
            poradi[0] = "První položka";
            Console.WriteLine(poradi[0]);

            string[] poleStringu = {"První","Druhý","Třetí"};
            List<string> s = new List<string>(poleStringu);
            foreach (string i in s)
                Console.WriteLine(i);
            Console.WriteLine(s.Count());
            Console.WriteLine("Vítej v losovačce.");
            char volba = '0';
            while (volba != '3')
            {
                Console.WriteLine("Vyber jednu z možností:");
                Console.WriteLine("1. Losování\n2. Výpis vylosovaných čísel\n3.Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (volba)
                {
                    case '1':
                        Console.WriteLine("Padlo číslo: {0}", losovac.Losuj());
                        break;
                    case '2':
                        Console.WriteLine("Padla čísla: {0}", losovac.Vypis());
                        break;
                    case '3':
                        Console.WriteLine("Děkuji  za použití programu.");
                        break;
                    default:
                        Console.WriteLine("Zadali jste špatně, zadejte znovu.");
                        break;

                }
            }
        }
    }
}
