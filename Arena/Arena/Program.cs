using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kostka sestistena = new Kostka();
            Kostka desetistena = new Kostka(10);
            Console.WriteLine("Počet stěn je: {0}", sestistena.VratPocetSten());
            Console.WriteLine("Počet stěn je: {0}", desetistena.VratPocetSten());
            Console.WriteLine(sestistena);
            Console.WriteLine(desetistena);
            */

            /*
            Kostka sestistena = new Kostka();
            Kostka desetistena = new Kostka(10);
            Console.WriteLine(sestistena);
            for (int i = 0; i < 10; i++)
                Console.Write(sestistena.hod() + " ");

            Console.Write("\n\n");
            Console.WriteLine(desetistena);
            for (int i = 0; i < 10; i++)
                Console.Write(desetistena.hod() + " ");

             */

            /*
            int a = 56;
            int b = 28;
            Uzivatel u = new Uzivatel("Jan Novák", 28);
            Uzivatel v = new Uzivatel("Josef Nový", 32);
            Console.WriteLine("a: {0}\nb: {1}\nu: {2}\nv: {3}\n", a, b, u, v);
            // přiřazování
            a = b;
            u = v;
            Console.WriteLine("a: {0}\nb: {1}\nu: {2}\nv: {3}\n", a, b, u, v);
            // změna
            v.jmeno = "John Dee";
            v.vek = 58;
            Console.WriteLine("u: {0}\nv: {1}\n",u,v);
            // nulování
            v = null;
            Console.WriteLine("u: {0}\nv: {1}\n", u, v);
             */

            /*
            Kostka kostka = new Kostka(10);
            Bojovnik bojovnik = new Bojovnik("Sairus", 100, 20, 10, kostka);

            Console.WriteLine("Bojovník: {0}", bojovnik);
            Console.WriteLine("Naživu: {0}", bojovnik.Nazivu());
            Console.WriteLine("Život: {0}", bojovnik.GrafickyZivot());

            Bojovnik souper = new Bojovnik("eNNy", 60, 18, 15, kostka);
            souper.Utoc(bojovnik);

            Console.WriteLine(souper.VratPosledniZpravu());
            Console.WriteLine(bojovnik.VratPosledniZpravu());

            Console.WriteLine("Život: {0}",bojovnik.GrafickyZivot());
             */

            // vytvoření objektů
            Kostka kostka = new Kostka(10);
            Bojovnik sairus = new Bojovnik("Sairus", 100, 20, 10, kostka);
            Bojovnik enny = new Mag("eNNy", 60, 18, 15, kostka, 30, 45);
            Arena arena = new Arena(sairus, enny, kostka);
            // zapas
            arena.Zapas();
            

            Console.ReadKey();
            
        }
    }
}
