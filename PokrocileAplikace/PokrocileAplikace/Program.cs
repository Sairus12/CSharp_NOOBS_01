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
            sim = sim.ToLower();
            for (int i = 0; i < simpsonovi.Length; i++)
            {
                simpsonovi[i] = simpsonovi[i].ToLower();
            }

                Array.Sort(simpsonovi);
            int pozice = Array.IndexOf(simpsonovi, sim);
            if (pozice >= 0)
                Console.Write("Tohle je {0}. simpson v pořadí.",pozice + 1);
            else
                Console.Write("Hele, tohle není simpson!");
            */

            /*
            Console.WriteLine("Vítej v počítátoru průměru tvých známek. Kolik známek budeš zadávat? ");
            int pocet = int.Parse(Console.ReadLine());
            int[] znamka = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadej {0}. známku: ", i + 1);
                znamka[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Průměr známek je: {0}", znamka.Average());
             */

            /*
            string s = "Programátor se zasekne ve sprše, protože instrukce na šampónu byly: Namydlit, omýt, opakovat.";
            Console.WriteLine(s);
            s = s.ToLower();

            int samohlasky = 0;
            int souhlasky = 0;

            string samo = "aeiouyáéěíóúůý";
            string sou = "bcčdďfghjklmnpqrřsštťvwxzž";


            foreach (char c in s)
            {
                if (samo.Contains(c))
                    samohlasky++;
                else
                    if (sou.Contains(c))
                    souhlasky++;
            }

            Console.Write("Počet samohlasek {0}\nPočet souhlasek {1}\nPočet nepísmen {2}", souhlasky, samohlasky, s.Length - (souhlasky + samohlasky));
            */

            /********************** Vložení na určitou pozici ************************
            Console.WriteLine("Já bych všechny ty internety zakázala.");
            Console.WriteLine("Já bych všechny ty internety zakázala.".Insert(29,"ne"));
            */

            /********************** Odstranění od určité pozice *********************
            Console.WriteLine("Kdo se směje naposled, ten je admin.");
            Console.WriteLine("Kdo se směje naposled, ten je admin.".Remove(12, 9));
            */

            /********************** Vytvoří substring (vytáhne něco ze stringu) od určité pozice ***********************
            Console.WriteLine("Kdo se směje naposled, ten je admin.");
            Console.WriteLine("Kdo se směje naposled, ten je admin.".Substring(13,8));
             */
            /********************** Porovnává dva řetezce -1 - 1. před 2. (abecedně), 0 - shodné, 1 - 2. před 1. (abecedně) ***********************
            Console.WriteLine("akát".CompareTo("blýskavice"));
            */

            /*
            string s = ".. ... .-.. .- -. -.. ... --- ..-. -";
            Console.WriteLine("Původní řetzec je {0}", s);

            string zprava = "";

            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
                                        "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                                        "...-", ".--", "-..-", "-.--", "--.."};

            string[] znaky = s.Split(' ');

            foreach (string morseuvZnak in znaky)
            {
                char abecedniZnak = '?';
                int index = Array.IndexOf(morseovyZnaky,morseuvZnak);
                if (index >= 0)
                    abecedniZnak = abecedniZnaky[index];
                zprava += abecedniZnak;
            }

            Console.WriteLine("Dekodovany kod je {0}",zprava);
             */


            Console.ReadKey();

        }
    }
}
