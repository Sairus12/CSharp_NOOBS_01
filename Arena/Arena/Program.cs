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

            Kostka sestistena = new Kostka();
            Kostka desetistena = new Kostka(10);
            Console.WriteLine(sestistena);
            for (int i = 0; i < 10; i++)
                Console.Write(sestistena.hod() + " ");

            Console.Write("\n\n");
            Console.WriteLine(desetistena);
            for (int i = 0; i < 10; i++)
                Console.Write(desetistena.hod() + " ");

            int a = 56;
            Uzivatel u = new Uzivatel("Pepa", 56);
                Console.ReadKey();
        }
    }
}
