using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statika
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzivatel u = new Uzivatel("Tomáš Marný", "heslojeveslo");
            Console.WriteLine("ID prvního uživatele: {0}", u.VratId());
            Uzivatel v = new Uzivatel("Olí Znusinudle", "csfd1fg");
            Console.WriteLine("ID druhého uživatele: {0}", v.VratId());
            Console.WriteLine("Minimální délka hesla uživatele je: {0}", Uzivatel.VratMinimalniDelkuHesla());
            Console.WriteLine("Validnost hesla \"heslo\" je: {0}", Uzivatel.ZvalidujHeslo("heslo"));
            Console.ReadKey();

            Console.WriteLine("\n\n\n");
            Kalendar kalendar = new Kalendar();
            Console.WriteLine(kalendar.VratNastaveni());
            Console.ReadKey();
        }
    }
}
