using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Jadro
    {
        public Databaze databaze;
        public Jadro()
        {
            databaze = new Databaze();
        }

        public DateTime ZjistiDatum()
        {
            Console.WriteLine("Zadejte datum ve tvaru [1.1.2012 14:00]");
            DateTime datum = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(),out datum))
                Console.WriteLine("Špatně zapsané datum, zapište jej znovu.");
            return datum;
        }
        public void VypisZaznamy(int cisloZvirete)
        {
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(cisloZvirete);
            foreach (Zaznam z in zaznamy)
                Console.WriteLine(z);
        }
        public void PridejZaznam()
        {
            Console.WriteLine("Zadej číslo zvířete: ");
            int cisloZvirete = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej jméno zvířete: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte poznámku ke zvířeti: ");
            string pozn = Console.ReadLine();
            
            databaze.PridejZaznam(cisloZvirete, jmeno, pozn);
        }
        public void VyhledejZaznamy()
        {
            Console.WriteLine("Zadejte číslo zvířete, které chcete vyhledat: ");
            int cisloZvirete = int.Parse(Console.ReadLine());
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(cisloZvirete);
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                Console.WriteLine("Nenalezeny žádné záznamy.");
        }
        public void VymazZaznamy()
        {
            Console.WriteLine("Zadejte číslo zvířete, které chcete vymazat: ");
            int cisloZvirete = int.Parse(Console.ReadLine());
            databaze.VymazZaznamy(cisloZvirete);
        }
    }
}
