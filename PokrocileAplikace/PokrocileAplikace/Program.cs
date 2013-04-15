using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokrocileAplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            int[] pole;
            pole = new int[10];
            for (int i = 0; i < 10; i++)
            {
                pole[i] = i + 1;
            }
            foreach (int i in pole)
            {
                Console.Write("{0} ", i);
            }

            */

            /*
            string[] simpsonovi = {"Maggie","Marge","Bart","Homer","Lisa"};
            Array.Sort(simpsonovi);
            foreach (string i in simpsonovi)
                Console.Write("\n{0} ",i);
            */

            /*
            int[] cisla = {4,5,8,3,98,24,087};
            Array.Sort(cisla);
            foreach (int a in cisla)
                Console.Write("{0} ",a);
            */

            /*
            string[] simpsonovi = { "Maggie", "Marge", "Bart", "Homer", "Lisa" };
            Array.Sort(simpsonovi);
            foreach (string a in simpsonovi)
                Console.Write("{0} ", a);
            Console.Write("\n");
            Array.Reverse(simpsonovi);
            foreach (string a in simpsonovi)
                Console.Write("{0} ", a); 
             */
    
            /*
            string[] simpsonovi = { "Maggie", "Marge", "Bart", "Homer", "Lisa" };

            string sim;
            Console.Write("Zadej jméno svého oblíbeného simpsona: ");
            sim = Console.ReadLine();
            Array.Sort(simpsonovi);
            int pozice = Array.IndexOf(simpsonovi, sim);
            if (pozice >= 0)
                Console.Write("Tohle je {0}. simpson v pořadí.",pozice + 1);
            else
                Console.Write("Hele, tohle není simpson!");
            */

            Console.WriteLine("Vítej v počítátoru průměru tvých známek. Kolik známek budeš zadávat? ");
            int pocet = int.Parse(Console.ReadLine());
            int[] znamka = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej {0}. známku: ", i + 1);
                znamka[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Průměr známek je: {0}", znamka.Average());


            
            Console.ReadKey();

        }
    }
}
