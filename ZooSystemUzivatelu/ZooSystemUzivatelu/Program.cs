using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Program
    {
        static void Main(string[] args)
        {
            string jmeno;
            Vypisy vypisy = new Vypisy();
            Jadro jadro = new Jadro();
            Admin admin = new Admin("Jan", "Tůma", 400, 6, 2);
            Uzivatel uzivatel = new Uzivatel("Nikola", "Tůmová", 40, 3);
            do
            {
                Console.WriteLine("Zadejte uživatelské jméno:");
                jmeno = Console.ReadLine();
            }
            while ((jmeno.ToLower() != "uzivatel") && (jmeno.ToLower() != "admin"));

            char volba = '0';
            while (volba != '4')
            {
                if (jmeno.ToLower() == "uzivatel")
                    vypisy.VypisUvodniObrazovku(uzivatel);
                else if (jmeno.ToLower() == "admin")
                    vypisy.VypisUvodniObrazovku(admin);
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Vyberte jednu z možností: ");
                Console.WriteLine("1 - Přidání záznamu");
                Console.WriteLine("2 - Vyhledávání v záznamech");
                Console.WriteLine("3 - Mazání záznamů");
                Console.WriteLine("4 - Konec programu");
                Console.WriteLine("5 - Odhlášení ze systému");
                volba = Console.ReadKey().KeyChar;
                switch (volba)
                 {
                    case '1':
                        Console.Clear();
                        jadro.PridejZaznam();
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        jadro.VyhledejZaznamy();
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        if (jmeno.ToLower() == "uzivatel")
                            Console.WriteLine("Jste jen uživatel, emáte přístup k mazání záznamů.\nObraťte se na správce systému.");
                        else if(jmeno.ToLower() == "admin")
                            jadro.VymazZaznamy();

                        Console.ReadKey();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program.");
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Zadejte uživatelské jméno:");
                        jmeno = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        Console.ReadKey();
                        break;
                            }
                        }

            Console.ReadKey();
        }
    }
}
